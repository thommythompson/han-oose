using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.RequestDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using HAN.ICDETool.Services.ResponseDtos;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace HAN.ICDETool.Services.Services;

public class AccountService : IAccountService
{
    private readonly ILogger<AccountService> _logger;
    private readonly SignInManager<Persoon> _signInManager;
    private readonly RoleManager<IdentityRole<int>> _roleManager;
    private readonly UserManager<Persoon> _userManager;
    private readonly IConfiguration _config;

    public AccountService(
        ILogger<AccountService> logger, 
        SignInManager<Persoon> signInManager,
        RoleManager<IdentityRole<int>> roleManager, 
        UserManager<Persoon> userManager,
        IConfiguration config
    )
    {
        _logger = logger;
        _signInManager = signInManager;
        _roleManager = roleManager;
        _userManager = userManager;
        _config = config;
    }

    public async Task<TokenResponseDto> CreateToken(TokenRequestDto tokenRequestDto)
    {
        var user = await _userManager.FindByNameAsync(tokenRequestDto.Username);

        if(user != null)
        {
            var result = await _signInManager.CheckPasswordSignInAsync(user, tokenRequestDto.Password, false);

            if (result.Succeeded)
            {
                // Create the token
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Voornaam + " " + user.Achternaam),
                    new Claim(ClaimTypes.NameIdentifier, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName)
                };

                var userRoles = await _userManager.GetRolesAsync(user);
                foreach (string userRole in userRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, userRole));
                    var role = await _roleManager.FindByNameAsync(userRole);
                    if(role != null)
                    {
                        var roleClaims = await _roleManager.GetClaimsAsync(role);
                        foreach(Claim roleClaim in roleClaims)
                        {
                            claims.Add(roleClaim);
                        }
                    }
                }

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

                var token = new JwtSecurityToken(
                    _config["Tokens:Issuer"],
                    _config["Tokens:Audience"],
                    claims,
                    signingCredentials: creds,
                    expires: DateTime.UtcNow.AddMinutes(200));

                return new TokenResponseDto()
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = token.ValidTo
                };
            }
            throw new InvalidCredentialException("Inloggen mislukt, controleer je credentials.");
        }

        throw new KeyNotFoundException("Gebruiker niet gevonden, controleer je credentials.");
    }
    
}
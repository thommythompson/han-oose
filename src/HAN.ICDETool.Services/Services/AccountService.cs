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
    private readonly ILogger<AccountService> logger;
    private readonly SignInManager<Persoon> signInManager;
    private readonly UserManager<Persoon> userManager;
    private readonly IConfiguration config;

    public AccountService(
        ILogger<AccountService> logger, 
        SignInManager<Persoon> signInManager, 
        UserManager<Persoon> userManager,
        IConfiguration config
    )
    {
        this.logger = logger;
        this.signInManager = signInManager;
        this.userManager = userManager;
        this.config = config;
    }

    public async Task<TokenResponseDto> CreateToken(TokenRequestDto tokenRequestDto)
    {
        var user = await userManager.FindByNameAsync(tokenRequestDto.Username);

        if(user != null)
        {
            var result = await signInManager.CheckPasswordSignInAsync(user, tokenRequestDto.Password, false);

            if (result.Succeeded)
            {
                // Create the token
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Tokens:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

                var token = new JwtSecurityToken(
                    config["Tokens:Issuer"],
                    config["Tokens:Audience"],
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
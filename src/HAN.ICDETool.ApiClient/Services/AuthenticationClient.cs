using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Json;
using Flurl;
using Flurl.Http;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;
using Microsoft.IdentityModel.Tokens;

namespace HAN.ICDETool.ApiClient.Services;

public class AuthenticationClient : IAuthenticationClient
{
    private FlurlClient _httpClient;
    private string _username;
    private string _password;
    private JwtSecurityToken _jwtSecurityToken;
    private TokenResponseDto _token;
    private string _baseUrl;

    public AuthenticationClient(string baseUrl)
    {
        _baseUrl = baseUrl;
        
        _httpClient = new FlurlClient();
    }

    public async Task<string> GetToken(string username, string password)
    {
        _username = username;
        _password = password;
        _token = null;
        
        await GenerateNewToken();
        
        return _token.Token;
    }
    
    public async Task<string> GetToken()
    {
        if (TokenIsValid())
            return _token.Token;
        
        if (null == _username || null == _password)
            throw new Exception("Provide credentials first");

        await GenerateNewToken();

        return _token.Token;
    }
    
    public async Task<JwtSecurityToken> GetJwtToken(string username, string password)
    {
        _username = username;
        _password = password;
        _token = null;
        
        await GenerateNewToken();
        
        return _jwtSecurityToken;
    }
    
    public async Task<JwtSecurityToken> GetJwtToken()
    {
        if (TokenIsValid())
            return _jwtSecurityToken;
        
        if (null == _username || null == _password)
            throw new Exception("Provide credentials first");

        await GenerateNewToken();

        return _jwtSecurityToken;
    }

    private async Task GenerateNewToken()
    {
        var tokenRequestDto = new TokenRequestDto()
        {
            Username = _username,
            Password = _password
        };

        var url = Url.Combine(_baseUrl, "/CreateToken");
        
        _token = await url.PostJsonAsync(tokenRequestDto).ReceiveJson<TokenResponseDto>();

        await GenerateJwtToken(_token);
    }    
    
    private async Task<JwtSecurityToken> GenerateJwtToken(TokenResponseDto token)
    {
        var handler = new JwtSecurityTokenHandler();
        return handler.ReadJwtToken(token.Token);
    }

    public bool TokenIsValid()
    {
        return null != _token && _token.Expiration > DateTimeOffset.Now;
    }
    
    public void Clear()
    {
        _token = null;
        _username = _password = null;
    }
}
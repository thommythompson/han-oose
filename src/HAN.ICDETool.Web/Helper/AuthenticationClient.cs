using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Blazored.LocalStorage;
using Flurl;
using Flurl.Http;
using HAN.ICDETool.ApiClient;
using HAN.ICDETool.ApiClient.Services;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Web.Helper;

public class AuthenticationClient : IAuthenticationClient
{
    private ILocalStorageService _localStorageService;
    private IApiClientConfig _config;
    
    private FlurlClient _httpClient;
    private string _username;
    private string _password;
    private string _baseUrl { get => _config.ServerlessBaseUrl; }
    
    public AuthenticationClient(IApiClientConfig apiClientConfig, ILocalStorageService localStorageService)
    {
        _config = apiClientConfig;
        _localStorageService = localStorageService;

        _httpClient = new FlurlClient();
    }

    public async Task Authenticate(string username, string password)
    {
        _username = username;
        _password = password;

        await GenerateNewToken();
    }
    
    public async Task<string> GetToken()
    {
        var token = await RetrieveCurrentToken();

        if (token.IsValid)
            return token.Token;
            
        if (null == _username || null == _password)
            throw new Exception("Provide credentials first");

        GenerateNewToken();

        token = await RetrieveCurrentToken();
        
        return token.Token;
    }

    private async Task GenerateNewToken()
    {
        var tokenRequestDto = new TokenRequestDto()
        {
            Username = _username,
            Password = _password
        };

        var url = Url.Combine(_baseUrl, "/CreateToken");
        
        var token = await url.PostJsonAsync(tokenRequestDto).ReceiveJson<TokenResponseDto>();
        
        await _localStorageService.SetItemAsStringAsync("token", token.Token);
    }
    
    public async Task Logout()
    {
        await _localStorageService.ClearAsync();
        _username = _password = null;
    }
    
    public async Task<ValidatedToken> RetrieveCurrentToken()
    {
        var tokenFromStorage = await _localStorageService.GetItemAsStringAsync("token");
        return new ValidatedToken(tokenFromStorage);
    }
    
    public class ValidatedToken
    {
        public string Token { get; }
        public JwtSecurityToken JwtSecurityToken { get; }
        public bool IsValid
        {
            get => ExpirationDate > DateTimeOffset.Now;
        }
        public DateTimeOffset ExpirationDate
        {
            get => JwtSecurityToken.ValidTo;
        }

        public ValidatedToken(string token)
        {
            Token = token;
            
            var handler = new JwtSecurityTokenHandler();
            JwtSecurityToken =  handler.ReadJwtToken(token);
        }
    }
}
using System.IdentityModel.Tokens.Jwt;

namespace HAN.ICDETool.ApiClient.Services;

public interface IAuthenticationClient
{
    Task Authenticate(string username, string password);
    Task<string> GetToken();
    Task Logout();
}
using System.IdentityModel.Tokens.Jwt;

namespace HAN.ICDETool.ApiClient.Services;

public interface IAuthenticationClient
{
    Task<string> GetToken(string username, string password);
    Task<string> GetToken();
    Task<JwtSecurityToken> GetJwtToken(string username, string password);
    Task<JwtSecurityToken> GetJwtToken();
    bool TokenIsValid();
    void Clear();
}
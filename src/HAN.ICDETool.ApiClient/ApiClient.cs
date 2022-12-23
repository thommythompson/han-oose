using HAN.ICDETool.ApiClient.Services;
using Flurl;
using Flurl.Http;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.ApiClient;

public class ApiClient
{
    private HttpClientWrapper _httpClient;
    private IAuthenticationClient _authenticationClient;
    private ILesMateriaalClient _lesMateriaalClient;
    private IBeoordelingClient _beoordelingClient;

    public ApiClient(string baseUrl)
    {
        _authenticationClient = new AuthenticationClient(baseUrl);
        _httpClient = new HttpClientWrapper(baseUrl, _authenticationClient);
        _lesMateriaalClient = new LesMateriaalClient(_httpClient);
        _beoordelingClient = new BeoordelingClient(_httpClient);
    }

    public async Task Authenticate(string username, string password)
    {
        await _authenticationClient.GetToken(username, password);
    }

    public async Task<IEnumerable<string>> GetIdentityRoles()
    {
        return await _authenticationClient.GetRoles();
    }
    
    public bool IsAuthenticated()
    {
        return _authenticationClient.TokenIsValid();
    }

    public void Logout()
    {
        _authenticationClient.Clear();
    }

    public async Task<IEnumerable<LesMateriaalResponseDto>> FetchLesMateriaal()
    {
        return await _lesMateriaalClient.FetchLesMateriaal();
    }
    
    public async Task<IEnumerable<BeoordelingResponseDto>> FetchGekregenBeoordelingen()
    {
        return await _beoordelingClient.FetchGekregenBeoordelingen();
    }
    
    public async Task<IEnumerable<BeoordelingResponseDto>> FetchGegevenBeoordelingen()
    {
        return await _beoordelingClient.FetchGegevenBeoordelingen();
    }
}
using HAN.ICDETool.ApiClient.Services;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.ApiClient;

public class ApiClient
{
    private HttpClientWrapper _httpClient;
    private IAuthenticationClient _authenticationClient;
    private ILesMateriaalClient _lesMateriaalClient;
    private IBeoordelingClient _beoordelingClient;

    public ApiClient(IApiClientConfig config, IAuthenticationClient authenticationClient)
    {
        _authenticationClient = authenticationClient;
        _httpClient = new HttpClientWrapper(config.ServerlessBaseUrl, _authenticationClient);
        _lesMateriaalClient = new LesMateriaalClient(_httpClient);
        _beoordelingClient = new BeoordelingClient(_httpClient);
    }

    public async Task Authenticate(string username, string password)
    {
        await _authenticationClient.Authenticate(username, password);
    }

    public void Logout()
    {
        _authenticationClient.Logout();
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
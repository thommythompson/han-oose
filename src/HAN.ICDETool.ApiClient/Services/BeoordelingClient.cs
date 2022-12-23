using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.ApiClient.Services;

public class BeoordelingClient : IBeoordelingClient
{
    private HttpClientWrapper _httpClient;
    
    public BeoordelingClient(HttpClientWrapper httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<BeoordelingResponseDto>> FetchGekregenBeoordelingen()
    {
        string uri = "/Beoordeling/Gekregen";
        return await _httpClient.GetWithAuth<BeoordelingResponseDto>(uri);
    }

    public async Task<IEnumerable<BeoordelingResponseDto>> FetchGegevenBeoordelingen()
    {
        string uri = "/Beoordeling/Gegeven";
        return await _httpClient.GetWithAuth<BeoordelingResponseDto>(uri);
    }
}
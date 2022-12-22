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

    public ApiClient(string baseUrl)
    {
        _authenticationClient = new AuthenticationClient(baseUrl);
        _httpClient = new HttpClientWrapper(baseUrl, _authenticationClient);
        _lesMateriaalClient = new LesMateriaalClient(_httpClient);
    }

    public async Task Authenticate(string username, string password)
    {
        await _authenticationClient.GetToken(username, password);
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
}
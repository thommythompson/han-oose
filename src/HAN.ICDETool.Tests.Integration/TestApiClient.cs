using Blazored.LocalStorage;
using Bunit;
using HAN.ICDETool.ApiClient;
using HAN.ICDETool.ApiClient.Services;
using HAN.ICDETool.Web.Helper;

namespace HAN.ICDETool.Tests.Integration;

public class TestApiClient
{
    private IAuthenticationClient _authService;
    private ILesMateriaalClient _lesMateriaalService;
    private ApiClient.ApiClient _apiClient;
    
    [SetUp]
    public void Setup()
    {
        IApiClientConfig apiClientConfig = new ApiClientConfig
        {
            ServerlessBaseUrl = "https://localhost:7028/"
        };
        
        using var ctx = new Bunit.TestContext();
        var localStorage = ctx.AddBlazoredLocalStorage();
        
        _authService = new AuthenticationClient(apiClientConfig, localStorage);
        _apiClient = new ApiClient.ApiClient(apiClientConfig, _authService);
        _lesMateriaalService = new LesMateriaalClient(new HttpClientWrapper(apiClientConfig.ServerlessBaseUrl, _authService));
    }
    
    [Test]
    public async Task TestAuthentication()
    {
        await _authService.Authenticate("student1@han.nl", "P@ssw0rd");
        var result = await _authService.GetToken();
        
        Assert.NotNull(result);
    }
    
    [Test]
    public async Task TestAuthenticationViaClient()
    {
        await _apiClient.Authenticate("student1@han.nl", "P@ssw0rd");
    }
    
    [Test]
    public async Task TestFetchLesMateriaalViaClient()
    {
        await _apiClient.Authenticate("student1@han.nl", "P@ssw0rd");
        var result = await _apiClient.FetchLesMateriaal();
        
        Assert.NotNull(result);
    }
    
    [Test]
    public async Task TestFetchGekregenBeoordelingenViaClient()
    {
        await _apiClient.Authenticate("student1@han.nl", "P@ssw0rd");
        var result = await _apiClient.FetchGekregenBeoordelingen();
        
        Assert.NotNull(result);
    }
    
    [Test]
    public async Task TestFetchGegevenBeoordelingenViaClient()
    {
        await _apiClient.Authenticate("docent1@han.nl", "P@ssw0rd");
        var result = await _apiClient.FetchGegevenBeoordelingen();
        
        Assert.NotNull(result);
    }
}
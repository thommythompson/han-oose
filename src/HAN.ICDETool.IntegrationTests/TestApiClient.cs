using HAN.ICDETool.ApiClient.Services;

namespace HAN.ICDETool.IntegrationTests;

public class TestApiClient
{
    private IAuthenticationClient _authService;
    private ILesMateriaalClient _lesMateriaalService;
    private ApiClient.ApiClient _apiClient;
    
    [SetUp]
    public void Setup()
    {
        string baseUrl = "https://localhost:7028/";
        
        _authService = new AuthenticationClient(baseUrl);
        _apiClient = new ApiClient.ApiClient(baseUrl);
        _lesMateriaalService = new LesMateriaalClient(new HttpClientWrapper(baseUrl, _authService));
    }
    
    [Test]
    public async Task TestAuthentication()
    {
        var result = await _authService.GetToken("student1@han.nl", "P@ssw0rd");
        
        Assert.NotNull(result);
        Assert.That(_authService.TokenIsValid, Is.True);
    }
    
    [Test]
    public async Task TestAuthenticationViaClient()
    {
        await _apiClient.Authenticate("student1@han.nl", "P@ssw0rd");
        
        Assert.That(_apiClient.IsAuthenticated, Is.True);
    }
    
    [Test]
    public async Task TestFetchLesMateriaalViaClient()
    {
        await _apiClient.Authenticate("student1@han.nl", "P@ssw0rd");
        var result = await _apiClient.FetchLesMateriaal();
        
        Assert.NotNull(result);
    }
}
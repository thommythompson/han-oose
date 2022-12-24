using HAN.ICDETool.Web.Helper;
using NUnit.Framework.Internal;
using Bunit;
using Blazored.LocalStorage.TestExtensions;

namespace HAN.ICDETool.Tests.Unit;

public class TestCustomAuthStateProvider 
{
    private TestExecutionContext _testExecutionContext;

    [Test]
    public async Task TestJwtParsing()
    {
        using var ctx = new Bunit.TestContext();
        var localStorage = ctx.AddBlazoredLocalStorage();
        localStorage.SetItemAsync("token",
            "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiU3R1ZGVudCAxIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZWlkZW50aWZpZXIiOiJzdHVkZW50MUBoYW4ubmwiLCJzdWIiOiJzdHVkZW50MUBoYW4ubmwiLCJqdGkiOiJkYTY2NGFkYy01N2RlLTRmYTYtYmJhMS00MDM4YmM4YjVjYTQiLCJ1bmlxdWVfbmFtZSI6InN0dWRlbnQxQGhhbi5ubCIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IlN0dWRlbnQiLCJleHAiOjE2NzE4OTk2MDEsImlzcyI6Imh0dHBzOi8vbG9jYWxob3N0OjcwMjgvIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NzAyOC8ifQ.Y9A6C20dOIcapP9FRMpPW8OE327X1uTNVYJTpmrYJwt_yAe0XLjrA_6kIxVISvuymdXH0pqorP-MEvH_3CVGrw");
        
        var statePov = new CustomAuthStateProvider(localStorage);

        var state = await statePov.GetAuthenticationStateAsync();
        
        Assert.That(state.User.Identity.Name, Is.EqualTo("Student 1") );
    }
}
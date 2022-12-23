using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Security;
using Flurl;
using Flurl.Http;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.ApiClient.Services;

public class HttpClientWrapper
{
    private IAuthenticationClient _authenticationClient;
    private string _baseUrl;
    
    public HttpClientWrapper(string baseUrl, IAuthenticationClient authenticationClient)
    {
        _baseUrl = baseUrl;
        _authenticationClient = authenticationClient;
    }
    
    public async Task<IEnumerable<TReturn>> Get<TReturn>(string uri)
    {
        var url = Url.Combine(_baseUrl, uri);

        return await url.GetAsync().ReceiveJson<IEnumerable<TReturn>>();
    }
    
    public async Task<IEnumerable<TReturn>> GetWithAuth<TReturn>(string uri)
    {
        string token = await _authenticationClient.GetToken();
        

        var url = Url.Combine(_baseUrl, uri)
            .WithOAuthBearerToken(token);

        return await url.GetJsonAsync<IEnumerable<TReturn>>();
    }
    
    public async Task<IEnumerable<TReturn>> Post<TReturn>(string uri, object body)
    {
        var url = Url.Combine(_baseUrl, uri);
        
        return await url.PostJsonAsync(body).ReceiveJson<IEnumerable<TReturn>>();
    }
    
    public async Task<IEnumerable<TReturn>> PostWithAuth<TReturn>(string uri, object body)
    {
        string token = await _authenticationClient.GetToken();
        
        var url = Url.Combine(_baseUrl, uri)
            .WithOAuthBearerToken(token);
        
        return await url.PostJsonAsync(body).ReceiveJson<IEnumerable<TReturn>>();
    }
}
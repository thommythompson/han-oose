using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.ApiClient.Services;

public class LesMateriaalClient : ILesMateriaalClient
{
    private HttpClientWrapper _httpClient;
    
    public LesMateriaalClient(HttpClientWrapper httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<LesMateriaalResponseDto>> FetchLesMateriaal()
    {
        string uri = "/LesMateriaal";
        return await _httpClient.GetWithAuth<LesMateriaalResponseDto>(uri);
    }
}
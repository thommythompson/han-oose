using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.ApiClient.Services;

public interface IBeoordelingClient
{
    public Task<IEnumerable<BeoordelingResponseDto>> FetchGekregenBeoordelingen();
    public Task<IEnumerable<BeoordelingResponseDto>> FetchGegevenBeoordelingen();
}
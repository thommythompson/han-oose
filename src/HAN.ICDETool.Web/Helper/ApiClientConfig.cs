using HAN.ICDETool.ApiClient;
using HAN.ICDETool.ApiClient.Services;

namespace HAN.ICDETool.Web.Helper;

public class ApiClientConfig : IApiClientConfig
{
    public string ServerlessBaseUrl { get; init; }
}
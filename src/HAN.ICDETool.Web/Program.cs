using HAN.ICDETool.ApiClient;
using HAN.ICDETool.Services.Mappings;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using HAN.ICDETool.Web;
using HAN.ICDETool.Web.Helper;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.LocalStorage;
using HAN.ICDETool.ApiClient.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string serverlessBaseURI = builder.Configuration["ServerlessBaseURI"];

var mapper = AutoMapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddSingleton<IApiClientConfig>(new ApiClientConfig
{
    ServerlessBaseUrl = serverlessBaseURI
});
builder.Services.AddSingleton<IAuthenticationClient, AuthenticationClient>();
builder.Services.AddSingleton<ApiClient>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorageAsSingleton();
builder.Services.AddHttpContextAccessor();

await builder.Build().RunAsync();
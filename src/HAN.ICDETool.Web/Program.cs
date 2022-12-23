using HAN.ICDETool.ApiClient;
using HAN.ICDETool.Services.Mappings;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using HAN.ICDETool.Web;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

string serverlessBaseURI = builder.Configuration["ServerlessBaseURI"];

builder.Services.AddSingleton(new ApiClient(serverlessBaseURI));

var mapper = AutoMapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

await builder.Build().RunAsync();
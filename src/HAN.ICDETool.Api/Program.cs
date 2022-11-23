using HAN.ICDETool.Api.Configuration;
using HAN.ICDETool.Infrastructure.Data;
using System.Text.Json.Serialization;

namespace  HAN.ICDETool.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = Build(args);

        Run(builder);
    }
    
    static private WebApplicationBuilder Build(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        string environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        
        builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
            .AddEnvironmentVariables();

        builder.Services.AddControllersWithViews()
            .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

        builder.Services.AddDbContext<ICDEContext>();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        new DependencyInjection().AddServices(builder);

        return builder;
    }

    static private void Run(WebApplicationBuilder builder)
    {
        var app = builder.Build();
        
        app.UseSwagger();
        app.UseSwaggerUI();
        
        app.UseStaticFiles();

        app.UseRouting();
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action}/{id?}"
        );
        
        app.UseHttpsRedirection();
        
        app.Run();
    }
}
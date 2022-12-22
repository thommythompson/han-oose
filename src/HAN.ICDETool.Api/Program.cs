using System.Security.Claims;
using System.Text;
using HAN.ICDETool.Api.Configuration;
using HAN.ICDETool.Infrastructure.Data;
using System.Text.Json.Serialization;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.Mappings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;

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
        
        ConfigurationManager _config = builder.Configuration;

        builder.Services.AddControllersWithViews(cfg => cfg.Filters.Add(new AuthorizeFilter()))
            .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

        builder.Services.AddIdentity<Persoon, IdentityRole<int>>(cfg => 
            {
                cfg.User.RequireUniqueEmail = true;
                cfg.Password.RequiredLength = 8;
                cfg.SignIn.RequireConfirmedAccount = false;
            })
            .AddEntityFrameworkStores<ICDEContext>();

        builder.Services.AddAuthentication(cfg =>
                {
                    cfg.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    cfg.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }
            )
            .AddJwtBearer(cfg => 
            {
                cfg.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidIssuer = _config["Tokens:Issuer"],
                    ValidAudience = _config["Tokens:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"])),
                    NameClaimType = JwtRegisteredClaimNames.Name,
                    RoleClaimType = ClaimTypes.Role
                };
            });
        
        builder.Services.AddDbContext<ICDEContext>();

        builder.Services.AddEndpointsApiExplorer();
        
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(
                builder =>
                {
                    builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
        });
        
        ConfigureSwagger(builder.Services);

        var mapper = AutoMapperConfig.CreateMapper();
        builder.Services.AddSingleton(mapper);
        
        new DependencyInjection().AddServices(builder);

        return builder;
    }

    static private void Run(WebApplicationBuilder builder)
    {
        var app = builder.Build();
        
        RunSeeding(app);
        
        app.UseSwagger();
        app.UseSwaggerUI();
        
        app.UseStaticFiles();

        app.UseCors();
            
        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action}/{id?}"
        );

        app.UseHttpsRedirection();
        
        app.Run();
    }
    
    static async void RunSeeding(WebApplication app)
    {
        var scopeFactory = app.Services.GetService<IServiceScopeFactory>();

        using (var scope = scopeFactory.CreateScope())
        {
            var seeder = scope.ServiceProvider.GetService<DbActions>();

            seeder.CreateDatabaseIfNotExists();
            await seeder.SeedIfDatabaseEmpty();
        }
    }

    static void ConfigureSwagger(IServiceCollection services)
    {
        services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter a valid token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            option.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                }
            });
        });
    }
}
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Infrastructure.Data;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.Services;
using HAN.ICDETool.ExporterService;

namespace HAN.ICDETool.Api.Configuration;

public class DependencyInjection
{
    public void AddServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped(typeof(IRepository<>),typeof(ICDERepository<>));
        builder.Services.AddTransient<ILesInrichtingService, LesInrichtingService>();
        builder.Services.AddTransient<ILesMateriaalService, LesMateriaalService>();
        builder.Services.AddTransient<ILesMateriaalExporter, LesMateriaalExporter>();
        builder.Services.AddTransient<DbActions, EntityFrameworkDbActions>();
    }
}
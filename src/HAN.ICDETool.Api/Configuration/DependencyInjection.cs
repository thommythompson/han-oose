using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Application.Services.Interfaces;
using HAN.ICDETool.Application.Services;
using HAN.ICDETool.Domain;
using HAN.ICDETool.Infrastructure.Data;
using HAN.ICDETool.Services.Exporter;
using Microsoft.EntityFrameworkCore;


namespace HAN.ICDETool.Api.Configuration;

public class DependencyInjection
{
    public void AddServices(WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<ILesMateriaalExporter, LesMateriaalExporter>();
        builder.Services.AddTransient<ILesInrichtingRepository, LesInrichtingRepository>();
        builder.Services.AddTransient<ILesMateriaalRepository, LesMateriaalRepository>();
        builder.Services.AddTransient<ILesInrichtingService, LesInrichtingService>();
        builder.Services.AddTransient<ILesMateriaalService, LesMateriaalService>();
        builder.Services.AddTransient<IDbActions, DbActions>();
    }
}
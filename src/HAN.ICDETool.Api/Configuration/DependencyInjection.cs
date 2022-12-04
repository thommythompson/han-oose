using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Infrastructure.Data;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.Services;
using HAN.ICDETool.Services.ResponseDtos;
using HAN.ICDETool.ExporterService;
using HAN.ICDETool.Services.RequestDtos;

namespace HAN.ICDETool.Api.Configuration;

public class DependencyInjection
{
    public void AddServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped(typeof(IRepository<>),typeof(ICDERepository<>));
        builder.Services.AddTransient<ILesMateriaalService, LesMateriaalService>();
        builder.Services.AddTransient<IEntityService<LesInrichting, LesInrichtingRequestDto, LesInrichtingResponseDto>, LesInrichtingService>();
        builder.Services.AddTransient<IEntityService<LesMateriaal, LesMateriaalRequestDto, LesMateriaalResponseDto>, LesMateriaalService>();
        builder.Services.AddTransient<ILesMateriaalExporter, LesMateriaalExporter>();
        builder.Services.AddTransient<DbActions, EntityFrameworkDbActions>();
    }
}
using AutoMapper;
using HAN.ICDETool.Services.Dtos;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Core.Entities;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Services.Services;

public class LesInrichtingService : BaseEntityService<LesInrichting, LesInrichtingDto>, ILesInrichtingService
{
    public LesInrichtingService(IRepository<LesInrichting> repository, ILogger<BaseEntityService<LesInrichting, LesInrichtingDto>> logger, IMapper mapper) : base(repository, logger, mapper)
    {
    }
}
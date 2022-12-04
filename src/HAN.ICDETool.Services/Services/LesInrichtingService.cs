using AutoMapper;
using HAN.ICDETool.Services.ResponseDtos;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Services.Services;

public class LesInrichtingService : BaseEntityService<LesInrichting, LesInrichtingRequestDto, LesInrichtingResponseDto>, ILesInrichtingService
{
    public LesInrichtingService(IRepository<LesInrichting> repository, ILogger<BaseEntityService<LesInrichting, LesInrichtingRequestDto, LesInrichtingResponseDto>> logger, IMapper mapper) : base(repository, logger, mapper)
    {
    }
}
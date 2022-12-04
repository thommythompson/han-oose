using AutoMapper;
using HAN.ICDETool.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using HAN.ICDETool.Services.ResponseDtos;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.RequestDtos;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LesMateriaalController : BaseController<LesMateriaal, LesMateriaalRequestDto, LesMateriaalResponseDto, ILesMateriaalService>
{
    public LesMateriaalController(IEntityService<LesMateriaal, LesMateriaalRequestDto, LesMateriaalResponseDto> service, 
        ILogger<BaseController<LesMateriaal, LesMateriaalRequestDto, LesMateriaalResponseDto, ILesMateriaalService>> logger, 
        IMapper mapper) : base(service, logger, mapper)
    {
    }
}
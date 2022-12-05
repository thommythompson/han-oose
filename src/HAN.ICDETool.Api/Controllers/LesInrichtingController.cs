using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.ResponseDtos;
using Microsoft.AspNetCore.Mvc;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.RequestDtos;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LesInrichtingController : BaseController<LesInrichting, LesInrichtingRequestDto, LesInrichtingResponseDto,  ILesInrichtingService>
{
    public LesInrichtingController(ILesInrichtingService service, 
        ILogger<BaseController<LesInrichting, LesInrichtingRequestDto, LesInrichtingResponseDto, ILesInrichtingService>> logger, 
        IMapper mapper) : base(service, logger, mapper)
    {
    }
}
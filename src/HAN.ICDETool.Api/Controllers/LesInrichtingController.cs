using AutoMapper;
using HAN.ICDETool.Services.Dtos;
using Microsoft.AspNetCore.Mvc;
using HAN.ICDETool.Services.Interfaces;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LesInrichtingController : BaseController<LesInrichtingDto,  ILesInrichtingService>
{

    public LesInrichtingController(IEntityService<LesInrichtingDto> service, ILogger<BaseController<LesInrichtingDto, ILesInrichtingService>> logger, IMapper mapper) : base(service, logger, mapper)
    {
    }
}
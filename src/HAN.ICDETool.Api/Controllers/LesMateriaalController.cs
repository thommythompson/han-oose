using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using HAN.ICDETool.Services.Dtos;
using HAN.ICDETool.Services.Interfaces;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LesMateriaalController : BaseController<LesMateriaalDto, ILesMateriaalService>
{
    public LesMateriaalController(IEntityService<LesMateriaalDto> service, ILogger<BaseController<LesMateriaalDto, ILesMateriaalService>> logger, IMapper mapper) : base(service, logger, mapper)
    {
    }
}
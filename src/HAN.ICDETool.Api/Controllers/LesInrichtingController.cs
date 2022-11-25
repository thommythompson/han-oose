using Microsoft.AspNetCore.Mvc;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Application.Services.Interfaces;
using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LesInrichtingController : IApiController<LesInrichting>
{
    private ILesInrichtingService _lesService;
    
    public LesInrichtingController(ILesInrichtingService lesService)
    {
        _lesService = lesService;
    }
    
    [HttpGet]
    [Route("")]
    public IEnumerable<LesInrichting> Get()
    {
        return _lesService.Get();
    }

    [HttpGet]
    [Route("{id}")]
    public LesInrichting Get(int id)
    {
        return _lesService.GetById(id);
    }
}
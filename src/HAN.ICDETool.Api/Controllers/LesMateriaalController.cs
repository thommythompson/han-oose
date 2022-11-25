using Microsoft.AspNetCore.Mvc;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Application.Services.Interfaces;
using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LesMateriaalController : IApiController<LesMateriaal>
{
    private ILesMateriaalService _service;
    
    public LesMateriaalController(ILesMateriaalService service)
    {
        _service = service;
    }
    
    [HttpGet]
    [Route("")]
    public IEnumerable<LesMateriaal> Get()
    {
        return _service.Get();
    }

    [HttpGet]
    [Route("{id}")]
    public LesMateriaal Get(int id)
    {
        return _service.GetById(id);
    }
}
using AutoMapper;
using HAN.ICDETool.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using HAN.ICDETool.Services.ResponseDtos;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.Services;
using HAN.ICDETool.SharedKernel;
using Microsoft.AspNetCore.Authorization;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LesMateriaalController : BaseController<LesMateriaal, LesMateriaalRequestDto, LesMateriaalResponseDto, ILesMateriaalService>
{
    private ILesMateriaalService _service;
    private ILogger<BaseController<LesMateriaal, LesMateriaalRequestDto, LesMateriaalResponseDto, ILesMateriaalService>>
        _logger;

    public LesMateriaalController(ILesMateriaalService service, 
        ILogger<BaseController<LesMateriaal, LesMateriaalRequestDto, LesMateriaalResponseDto, ILesMateriaalService>> logger, 
        IMapper mapper) : base(service, logger, mapper)
    {
        _service = service;
        _logger = logger;
    }
    
    [HttpPost]
    [Route("{id:int}/Export")]
    [Authorize(Roles = "Docent, Student")]
    public IActionResult Export(int id, [FromBody]ExportFormaatDto format)
    {
        try
        {
            CustomFile lesMateriaal = _service.Export(format.ExportType, id);
        
            return File(lesMateriaal.FileContents, lesMateriaal.ContentType, lesMateriaal.FileName);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to export: {ex}");
            return BadRequest("Unable to export");
        }
    }
}
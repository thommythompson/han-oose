using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;
using Microsoft.AspNetCore.Mvc;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseInrichtingController : BaseController<CourseInrichting, CourseInrichtingRequestDto, CourseInrichtingResponseDto, ICourseInrichtingService>
{
    private ICourseInrichtingService _service;
    private ILogger<BaseController<CourseInrichting, CourseInrichtingRequestDto, CourseInrichtingResponseDto, ICourseInrichtingService>> _logger;
    
    public CourseInrichtingController(ICourseInrichtingService service, 
        ILogger<BaseController<CourseInrichting, CourseInrichtingRequestDto, CourseInrichtingResponseDto, ICourseInrichtingService>> logger, 
        IMapper mapper) : base(service, logger, mapper)
    {
        _service = service;
        _logger = logger;
    }
    
    [HttpPost]
    [Route("{id:int}/StartUitvoering")]
    public async Task<IActionResult> Export(int id, DateTime date)
    {
        try
        {
            try
            {
                return Ok(await _service.StartUitvoering(id, date));
            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest($"{ex}");
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to start courseuitvoering: {ex}");
            return BadRequest("Unable to start courseuitvoering");
        }
    }
}
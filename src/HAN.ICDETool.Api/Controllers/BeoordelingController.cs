using System.Security.Claims;
using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.Interfaces;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BeoordelingController : BaseController<Beoordeling, BeoordelingRequestDto, BeoordelingResponseDto, IBeoordelingService>
{
    private IBeoordelingService _service;
    private ILogger<BaseController<Beoordeling, BeoordelingRequestDto, BeoordelingResponseDto, IBeoordelingService>> _logger;
    
    public BeoordelingController(IBeoordelingService service, 
        ILogger<BaseController<Beoordeling, BeoordelingRequestDto, BeoordelingResponseDto, IBeoordelingService>> logger, 
        IMapper mapper) : base(service, logger, mapper)
    {
        _service = service;
        _logger = logger;
    }
    
    [Authorize(Roles = "Student")]
    [HttpGet]
    [Route("Gekregen")]
    public async Task<IActionResult> GetGekregenBeoordelingen(CancellationToken cancellationToken)
    {
        try
        {
            return Ok(await _service.ReadByStudentId(GetUserNameFromClaims() ,cancellationToken));
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to get entity: {ex}");
            return BadRequest("Unable to get entity");
        }
    }
    
    [Authorize(Roles = "Docent")]
    [HttpGet]
    [Route("Gegeven")]
    public async Task<IActionResult> GetGegevenBeoordelingen(CancellationToken cancellationToken)
    {
        try
        {
            return Ok(await _service.ReadByStudentId(GetUserNameFromClaims() ,cancellationToken));
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to get entity: {ex}");
            return BadRequest("Unable to get entity");
        }
    }

    private string GetUserNameFromClaims()
    {
        return User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).Select(c => c.Value).FirstOrDefault();
    }
}
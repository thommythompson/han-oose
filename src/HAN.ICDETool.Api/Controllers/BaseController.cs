using AutoMapper;
using HAN.ICDETool.Services.ResponseDtos;
using HAN.ICDETool.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
public abstract class BaseController<TEntity, TRequestDto, TResponseDto, IEntityService> 
    : ControllerBase where TResponseDto : BaseResponseDto 
{
    private IEntityService<TEntity, TRequestDto, TResponseDto> _service;
    private readonly ILogger<BaseController<TEntity, TRequestDto, TResponseDto, IEntityService>> _logger;
    private readonly IMapper _mapper;

    public BaseController(IEntityService<TEntity, TRequestDto, TResponseDto> service, 
        ILogger<BaseController<TEntity, TRequestDto, TResponseDto, IEntityService>> logger, 
        IMapper mapper)
    {
        _service = service;
        _logger = logger;
        _mapper = mapper;
    }
    
    [Authorize(Roles = "Docent, Student")]
    [HttpGet]
    [Route("")]
    public virtual async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            return Ok(await _service.Read(cancellationToken));
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to get entity: {ex}");
            return BadRequest("Unable to get entity");
        }
    }
    
    [Authorize(Roles = "Docent, Student")]
    [HttpGet]
    [Route("{id:int}")]
    public virtual async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _service.Read(id, cancellationToken);

            if (result != null) return Ok(result);
            return NotFound();
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to get entity by id: {ex}");
            return BadRequest("Unable to get entity by id");
        }
    }

    [Authorize(Roles = "Docent")]
    [HttpPut]
    [Route("")]
    public virtual async Task<IActionResult> Create([FromBody]TRequestDto entity, CancellationToken cancellationToken)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = await _service.Create(entity, cancellationToken);

                return Created($"/{typeof(TEntity).Name}/{result.Id}", result);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to create entity: {ex}");
        }
        return BadRequest("Unable to create entity");
    }

    [Authorize(Roles = "Docent")]
    [HttpPost]
    [Route("{id:int}")]
    public virtual async Task<IActionResult> Update(int id, [FromBody]TRequestDto entity, CancellationToken cancellationToken)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = await _service.Update(id, entity, cancellationToken);

                return Created($"/{typeof(TEntity).Name}/{result.Id}", result);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to update entity: {ex}");
        }
        return BadRequest("Unable to update entity");
    }

    [Authorize(Roles = "Docent")]
    [HttpDelete]
    [Route("{id:int}")]
    public virtual async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        try
        {
            await _service.Delete(id, cancellationToken); 
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to delete entity: {ex}");
            return BadRequest($"Unable to delete entity: {ex}");
        }
    }
}
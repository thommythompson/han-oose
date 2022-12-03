using AutoMapper;
using HAN.ICDETool.Services.Dtos;
using HAN.ICDETool.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HAN.ICDETool.Api.Controllers;

[ApiController]
public abstract class BaseController<TEntity, IEntityService> : ControllerBase where TEntity : BaseDto
{
    private IEntityService<TEntity> _service;
    private readonly ILogger<BaseController<TEntity, IEntityService>> _logger;
    private readonly IMapper _mapper;

    public BaseController(IEntityService<TEntity> service, ILogger<BaseController<TEntity, IEntityService>> logger, IMapper mapper)
    {
        _service = service;
        _logger = logger;
        _mapper = mapper;
    }
    
    [HttpGet]
    [Route("")]
    public IActionResult Get()
    {
        try
        {
            return Ok(_service.Read());
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to get entity: {ex}");
            return BadRequest("Unable to get entity");
        }
    }
    
    [HttpGet]
    [Route("{id:int}")]
    public IActionResult Get(int id)
    {
        try
        {
            var result = _service.Read(id);

            if (result != null) return Ok(result);
            return NotFound();
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to get entity by id: {ex}");
            return BadRequest("Unable to get entity by id");
        }
    }

    [HttpPut]
    [Route("")]
    public IActionResult Create(TEntity entity)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _service.Create(entity);

                return Created($"/{typeof(TEntity)}/{entity.Id}", entity);
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

    [HttpPost]
    [Route("")]
    public IActionResult Update(TEntity entity)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _service.Update(entity);

                return Created($"/{typeof(TEntity)}/{entity.Id}", entity);
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

    [HttpDelete]
    [Route("{id:int}")]
    public IActionResult Delete(int id)
    {
        try
        {
            _service.Delete(id);
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError($"Unable to delete entity: {ex}");
            return BadRequest("Unable to delete entity");
        }
    }
}
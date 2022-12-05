using AutoMapper;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Services.Services;

public abstract class BaseEntityService<TEntity, TRequestDto, TReponseDto> : IEntityService<TEntity, TRequestDto, TReponseDto> where TEntity : class, BaseEntity
{
    private readonly IRepository<TEntity> _repository;
    private readonly ILogger<BaseEntityService<TEntity, TRequestDto, TReponseDto>> _logger;
    private readonly IMapper _mapper;

    public BaseEntityService(IRepository<TEntity> repository, ILogger<BaseEntityService<TEntity, TRequestDto, TReponseDto>> logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }
    
    public virtual async Task<TReponseDto> Create(TRequestDto entity, CancellationToken cancellationToken)
    {
        var newEntity = _mapper.Map<TEntity>(entity);
        
        var result = await _repository.AddAsync(newEntity, cancellationToken);
        await _repository.SaveChangesAsync(cancellationToken);
        
        return _mapper.Map<TReponseDto>(result);
    }

    public virtual async Task<IEnumerable<TReponseDto>> Read(CancellationToken cancellationToken)
    {
        var result = await _repository.ListAsync(cancellationToken);
        return _mapper.Map<List<TReponseDto>>(result);
    }

    public virtual async Task<TReponseDto> Read(int id, CancellationToken cancellationToken)
    {
        var result = await _repository.GetByIdAsync(id, cancellationToken);
        return _mapper.Map<TReponseDto>(result);
    }

    public virtual async Task<TReponseDto> Update(int id, TRequestDto entity, CancellationToken cancellationToken)
    {
        var newEntity = _mapper.Map<TEntity>(entity);
        newEntity.Id = id;
        
        await _repository.UpdateAsync(newEntity, cancellationToken);
        await _repository.SaveChangesAsync(cancellationToken);
        var result = await _repository.GetByIdAsync(id, cancellationToken);
        
        return _mapper.Map<TReponseDto>(result);
    }

    public virtual async Task Delete(int id, CancellationToken cancellationToken)
    {
        try
        {
            var entity = await _repository.GetByIdAsync(id, cancellationToken);

            if(null == entity)
            {
                throw new Exception($"Entity with id {id} could not be found.");
            }

            await _repository.DeleteAsync(entity, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Delete operations failed: {ex}");
            throw new Exception("Delete operations failed");
        }
    }
}
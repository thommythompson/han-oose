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
    
    public virtual TReponseDto Create(TRequestDto entity)
    {
        var newEntity = _mapper.Map<TEntity>(entity);
        var result = _repository.AddAsync(newEntity).Result;
        _repository.SaveChangesAsync();
        return _mapper.Map<TReponseDto>(result);
    }

    public virtual IEnumerable<TReponseDto> Read()
    {
        var result = _repository.ListAsync().Result;
        return _mapper.Map<List<TReponseDto>>(result);
    }

    public virtual TReponseDto Read(int id)
    {
        var result =  _repository.GetByIdAsync(id).Result;
        return _mapper.Map<TReponseDto>(result);
    }

    public virtual TReponseDto Update(int id, TRequestDto entity)
    {
        var newEntity = _mapper.Map<TEntity>(entity);
        newEntity.Id = id;
        var result = _repository.UpdateAsync(newEntity);
        _repository.SaveChangesAsync();
        return _mapper.Map<TReponseDto>(result);
    }

    public virtual void Delete(int id)
    {
        var entity = _repository.GetByIdAsync(id).Result;
        _repository.DeleteAsync(entity);
        _repository.SaveChangesAsync();
    }
}
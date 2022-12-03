using AutoMapper;
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace HAN.ICDETool.Services.Services;

public abstract class BaseEntityService<T, TDto> : IEntityService<T> where T : class
{
    private readonly IRepository<T> _repository;
    private readonly ILogger<BaseEntityService<T, TDto>> _logger;
    private readonly IMapper _mapper;

    public BaseEntityService(IRepository<T> repository, ILogger<BaseEntityService<T, TDto>> logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public Task<T> Create(T entity)
    {
        return _repository.AddAsync(entity);
    }

    public Task<List<T>> Read()
    {
        return _repository.ListAsync();
    }

    public Task<T> Read(int id)
    {
        return _repository.GetByIdAsync(id);
    }

    public Task Update(T entity)
    {
        return _repository.UpdateAsync(entity);
    }

    public Task Delete(int id)
    {
        var entity = _repository.GetByIdAsync(id).Result;
        return _repository.DeleteAsync(entity);
    }
}
namespace HAN.ICDETool.Services.Interfaces;

public interface IEntityService<TEntity, TRequestDto, TReponseDto>
{
    public Task<TReponseDto> Create(TRequestDto entity, CancellationToken cancellationToken);
    public Task<IEnumerable<TReponseDto>> Read(CancellationToken cancellationToken);
    public Task<TReponseDto> Read(int id, CancellationToken cancellationToken);
    public Task<TReponseDto> Update(int id, TRequestDto entity, CancellationToken cancellationToken);
    public Task Delete(int id, CancellationToken cancellationToken);
}
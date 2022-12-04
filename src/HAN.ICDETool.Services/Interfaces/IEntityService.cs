namespace HAN.ICDETool.Services.Interfaces;

public interface IEntityService<TEntity, TRequestDto, TReponseDto>
{
    public Task<TReponseDto> Create(TRequestDto entity);
    public Task<IEnumerable<TReponseDto>> Read();
    public Task<TReponseDto> Read(int id);
    public Task<TReponseDto> Update(int id, TRequestDto entity);
    public Task<int> Delete(int id);
}
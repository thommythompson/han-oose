namespace HAN.ICDETool.Services.Interfaces;

public interface IEntityService<TEntity, TRequestDto, TReponseDto>
{
    public TReponseDto Create(TRequestDto entity);
    public IEnumerable<TReponseDto> Read();
    public TReponseDto Read(int id);
    public TReponseDto Update(int id, TRequestDto entity);
    public void Delete(int id);
}
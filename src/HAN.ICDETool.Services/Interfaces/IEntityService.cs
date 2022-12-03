namespace HAN.ICDETool.Services.Interfaces;

public interface IEntityService<T>
{
    public Task<T> Create(T entity);
    public Task<List<T>> Read();
    public Task<T> Read(int id);
    public Task Update(T entity);
    public Task Delete(int id);
}
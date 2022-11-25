namespace HAN.ICDETool.Application.Services.Interfaces;

public interface IEntityService<T>
{
    public IEnumerable<T> Get();
    public T GetById(int Id);
}
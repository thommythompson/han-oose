namespace HAN.ICDETool.Application.Repositories.Interfaces;

public interface IRepository<T>
{
    public IEnumerable<T> Get();
    public T GetById(int Id);
}
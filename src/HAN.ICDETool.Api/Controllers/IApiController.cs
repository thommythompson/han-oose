namespace HAN.ICDETool.Api.Controllers;

public interface IApiController<T>
{
    public IEnumerable<T> Get();
    public T Get(int id);
}
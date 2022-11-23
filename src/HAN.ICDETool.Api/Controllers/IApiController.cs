namespace HAN.ICDETool.Api.Controllers;

public interface IApiController<T>
{
    public IList<T> Get();
    public T Get(int id);
}
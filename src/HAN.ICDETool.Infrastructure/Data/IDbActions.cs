namespace HAN.ICDETool.Infrastructure.Data;

public interface IDbActions
{
    public Task Seed();
    public void Create();

    public Task CreateAndSeed();
}
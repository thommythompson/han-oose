namespace HAN.ICDETool.Infrastructure.Data;

public interface IDbActions
{
    public void Seed();
    public void Create();

    public void CreateAndSeed();
}
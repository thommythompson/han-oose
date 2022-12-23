namespace HAN.ICDETool.Infrastructure.Data;

public interface DbActions
{
    public Task SeedIfDatabaseEmpty();
    public void CreateDatabaseIfNotExists();
    
}
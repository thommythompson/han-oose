namespace HAN.ICDETool.Infrastructure.Data;

public abstract class DbActions
{
    public abstract void SeedIfDatabaseEmpty();
    public abstract void CreateDatabaseIfNotExists();

    public void CreateDatabaseIfNotExistsAndSeedIfDatabaseEmpty()
    {
        CreateDatabaseIfNotExists();
        SeedIfDatabaseEmpty();
    }
}
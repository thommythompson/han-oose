using Ardalis.Specification.EntityFrameworkCore;

namespace HAN.ICDETool.Infrastructure.Data;

public class ICDERepository<T> : RepositoryBase<T> where T : class
{
    
    private readonly ICDEContext _dbContext;

    public ICDERepository(ICDEContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}
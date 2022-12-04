using Ardalis.Specification.EntityFrameworkCore;
using HAN.ICDETool.Application.Repositories.Interfaces;

namespace HAN.ICDETool.Infrastructure.Data;

public class ICDERepository<T> : RepositoryBase<T>, IRepository<T> where T : class
{
    
    private readonly ICDEContext _dbContext;

    public ICDERepository(ICDEContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}
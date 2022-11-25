using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Domain;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Infrastructure.Data;

public class LesInrichtingRepository : ILesInrichtingRepository
{
    private readonly ICDEContext _icdeContext;

    public LesInrichtingRepository(ICDEContext icdeContext)
    {
        _icdeContext = icdeContext;
    }
    
    public IEnumerable<LesInrichting> Get()
    {
        return _icdeContext.LesInrichting;
    }

    public LesInrichting GetById(int Id)
    {
        return _icdeContext.LesInrichting.Where(t => t.Id == Id).First();
    }
}
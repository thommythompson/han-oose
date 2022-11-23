using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Domain;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Infrastructure.Data;

public class LesMateriaalRepository : ILesMateriaalRepository
{
    private readonly ICDEContext _icdeContext;

    public LesMateriaalRepository(ICDEContext icdeContext)
    {
        _icdeContext = icdeContext;
    }

    public IList<LesMateriaal> Get()
    {
        return _icdeContext.LesMateriaal.ToList();
    }

    public LesMateriaal GetById(int Id)
    {
        return _icdeContext.LesMateriaal.Where(t => t.Id == Id).First();
    }

    public IList<LesMateriaal> GetByLesId(int lesId)
    {
        return _icdeContext.LesInrichting.Where(t => t.Id == lesId).Select(t => t.LesMateriaal).ToList()[0];
    }
}
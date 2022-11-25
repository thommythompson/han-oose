using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Repositories.Interfaces;

public interface ILesMateriaalRepository : IRepository<LesMateriaal>
{
    public IEnumerable<LesMateriaal> Get();
    public LesMateriaal GetById(int Id);
    public IEnumerable<LesMateriaal> GetByLesId(int Id);
}
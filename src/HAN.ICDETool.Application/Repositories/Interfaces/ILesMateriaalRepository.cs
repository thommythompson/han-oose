using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Repositories.Interfaces;

public interface ILesMateriaalRepository
{
    public IList<LesMateriaal> Get();
    public LesMateriaal GetById(int Id);
    public IList<LesMateriaal> GetByLesId(int Id);
}
using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Repositories.Interfaces;

public interface ILesInrichtingRepository : IRepository<LesInrichting>
{
    public IEnumerable<LesInrichting> Get();
    public LesInrichting GetById(int Id);
}
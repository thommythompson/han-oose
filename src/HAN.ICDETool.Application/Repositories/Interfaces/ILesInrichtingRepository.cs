using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Repositories.Interfaces;

public interface ILesInrichtingRepository
{
    public IList<LesInrichting> Get();
    public LesInrichting GetById(int Id);
}
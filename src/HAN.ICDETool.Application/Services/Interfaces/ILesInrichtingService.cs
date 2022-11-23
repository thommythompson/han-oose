using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Services.Interfaces;

public interface ILesInrichtingService
{
    public IList<LesInrichting> Get();
    public LesInrichting GetById(int Id);
}
using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Services.Interfaces;

public interface ILesInrichtingService : IEntityService<LesInrichting>
{
    public IEnumerable<LesInrichting> Get();
    public LesInrichting GetById(int Id);
}
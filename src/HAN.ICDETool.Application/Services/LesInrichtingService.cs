using HAN.ICDETool.Application.Repositories.Interfaces;
using HAN.ICDETool.Application.Services.Interfaces;
using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Services;

public class LesInrichtingService : ILesInrichtingService
{
    private ILesInrichtingRepository _repository;
    
    public LesInrichtingService(ILesInrichtingRepository repository)
    {
        _repository = repository;
    }
    
    public IList<LesInrichting> Get()
    {
        return _repository.Get();
    }

    public LesInrichting GetById(int Id)
    {
        return _repository.GetById(Id);
    }
}
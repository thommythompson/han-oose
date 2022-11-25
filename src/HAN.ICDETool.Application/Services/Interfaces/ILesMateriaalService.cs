using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Services.Interfaces;

public interface ILesMateriaalService : IEntityService<LesMateriaal>
{
    IEnumerable<LesMateriaal> Get();
    LesMateriaal GetById(int id);
    IEnumerable<LesMateriaal> GetByLesId(int lesId);
    string Export(string formaat, int Id);
}
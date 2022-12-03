using HAN.ICDETool.Core.Entities;

namespace HAN.ICDETool.Services.Interfaces;

public interface ILesMateriaalService : IEntityService<LesMateriaal>
{
    IEnumerable<LesMateriaal> GetByLesId(int lesId);
    string Export(string formaat, int id);
}
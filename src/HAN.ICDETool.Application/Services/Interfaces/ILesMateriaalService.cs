using HAN.ICDETool.Domain;

namespace HAN.ICDETool.Application.Services.Interfaces;

public interface ILesMateriaalService
{
    IList<LesMateriaal> Get();
    LesMateriaal GetById(int id);
    IList<LesMateriaal> GetByLesId(int lesId);
    string Export(string formaat, int Id);
}
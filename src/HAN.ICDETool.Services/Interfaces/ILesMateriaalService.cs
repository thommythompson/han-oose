using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Interfaces;

public interface ILesMateriaalService : IEntityService<LesMateriaal, LesMateriaalRequestDto, LesMateriaalResponseDto>
{
    IEnumerable<LesMateriaalResponseDto> GetByLesId(int lesId);
    string Export(string formaat, int id);
}
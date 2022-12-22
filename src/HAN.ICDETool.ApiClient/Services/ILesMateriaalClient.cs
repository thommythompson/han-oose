using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.ApiClient.Services;

public interface ILesMateriaalClient
{
    public Task<IEnumerable<LesMateriaalResponseDto>> FetchLesMateriaal();
}
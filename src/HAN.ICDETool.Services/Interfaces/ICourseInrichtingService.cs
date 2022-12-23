using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Interfaces;

public interface ICourseInrichtingService : IEntityService<CourseInrichting, CourseInrichtingRequestDto, CourseInrichtingResponseDto>
{
    public Task<CourseUitvoeringResponseDto> StartUitvoering(int id, DateTime dateTime);
}
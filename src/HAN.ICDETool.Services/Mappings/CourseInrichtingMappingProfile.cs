using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Mappings;

public class CourseInrichtingMappingProfile : Profile
{
    public CourseInrichtingMappingProfile()
    {
        CreateMap<CourseInrichting, CourseInrichtingResponseDto>()
            .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
            .ReverseMap();
        
        CreateMap<CourseInrichting, CourseInrichtingRequestDto>()
            .ReverseMap();
    }
}
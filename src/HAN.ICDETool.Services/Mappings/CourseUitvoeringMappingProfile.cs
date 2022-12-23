using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Mappings;

public class CourseUitvoeringMappingProfile: Profile
{
    public CourseUitvoeringMappingProfile()
    {
        CreateMap<CourseUitvoering, CourseUitvoeringResponseDto>()
            .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
            .ReverseMap();
        
        CreateMap<CourseUitvoering, CourseUitvoeringRequestDto>()
            .ReverseMap();
    }
}
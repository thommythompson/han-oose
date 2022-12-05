using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Mappings;

public class CourseWeekUitvoeringMappingProfile : Profile
{
    public CourseWeekUitvoeringMappingProfile()
    {
        CreateMap<CourseWeekUitvoering, CourseWeekUitvoeringResponseDto>()
            .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
            .ReverseMap();
    }
}
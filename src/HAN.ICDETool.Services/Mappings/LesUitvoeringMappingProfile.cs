using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Mappings;

public class LesUitvoeringMappingProfile : Profile
{
    public LesUitvoeringMappingProfile()
    {
        CreateMap<LesUitvoering, LesUitvoeringResponseDto>()
            .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
            .ReverseMap();
    }
}
using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Application.Mappings;

public class LesMateriaalMappingProfile : Profile
{
    public LesMateriaalMappingProfile()
    {
        CreateMap<LesMateriaal, LesMateriaalResponseDto>()
            .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
            .ForMember(o => o.Inhoud, ex => ex.MapFrom(o => o.Inhoud))
            .ReverseMap();
        
        CreateMap<LesMateriaal, LesMateriaalRequestDto>()
            .ForMember(o => o.Inhoud, ex => ex.MapFrom(o => o.Inhoud))
            .ReverseMap();
    }
}
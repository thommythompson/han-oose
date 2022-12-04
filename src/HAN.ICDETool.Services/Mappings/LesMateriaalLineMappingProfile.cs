using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Application.Mappings;

public class LesMateriaalLineMappingProfile : Profile
{
    public LesMateriaalLineMappingProfile()
    {
        CreateMap<LesMateriaalLine, LesMateriaalLineResponseDto>()
            .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
            .ForMember(o => o.Line, ex => ex.MapFrom(o => o.Line))
            .ReverseMap();
        
        CreateMap<LesMateriaalLine, LesMateriaalLineRequestDto>()
            .ForMember(o => o.Line, ex => ex.MapFrom(o => o.Line))
            .ReverseMap();
    }
}
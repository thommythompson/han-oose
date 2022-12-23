using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Mappings;

public class LesInrichtingMappingProfile : Profile
{
    public LesInrichtingMappingProfile()
    {

        CreateMap<LesInrichting, LesInrichtingResponseDto>()
            .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
            .ForMember(o => o.Titel, ex => ex.MapFrom(o => o.Titel))
            .ForMember(o => o.Leerdoel, ex => ex.MapFrom(o => o.Leerdoel))
            .ReverseMap();
        
        CreateMap<LesInrichting, LesInrichtingRequestDto>()
            .ForMember(o => o.Titel, ex => ex.MapFrom(o => o.Titel))
            .ReverseMap();
    }
}
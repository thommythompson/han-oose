using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Mappings;

public class LeerdoelMappingProfile : Profile
{
    public LeerdoelMappingProfile()
    {
        CreateMap<Leerdoel, LeerdoelResponseDto>()
            .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
            .ForMember(o => o.Titel, ex => ex.MapFrom(o => o.Titel))
            .ForMember(o => o.Omschrijving, ex => ex.MapFrom(o => o.Omschrijving))
            .ReverseMap();
        
        CreateMap<Leerdoel, LeerdoelRequestDto>()
            .ForMember(o => o.Titel, ex => ex.MapFrom(o => o.Titel))
            .ForMember(o => o.Omschrijving, ex => ex.MapFrom(o => o.Omschrijving))
            .ReverseMap();
    }
}
using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.RequestDtos;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Mappings;

public class BeoordelingMappingProfile : Profile
{
    public BeoordelingMappingProfile()
    {
        CreateMap<Beoordeling, BeoordelingResponseDto>()
            .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
            .ForMember(o => o.DocentNaam, ex => ex.MapFrom(o => o.Docent.Voornaam + " " + o.Docent.Achternaam))
            .ForMember(o => o.StudentNaam, ex => ex.MapFrom(o => o.Student.Voornaam + " " + o.Student.Achternaam))
            .ReverseMap();

        CreateMap<Beoordeling, BeoordelingRequestDto>()
            .ReverseMap();
    }
}
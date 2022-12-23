using AutoMapper;
using HAN.ICDETool.Core.Entities;
using HAN.ICDETool.Services.ResponseDtos;

namespace HAN.ICDETool.Services.Mappings;

public class TentamenUitvoeringMappingProfile : Profile
{
    public TentamenUitvoeringMappingProfile()
    {
        CreateMap<TentamenUitvoering, TentamenUitvoeringResponseDto>()
            .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
            .ReverseMap();
    }
}
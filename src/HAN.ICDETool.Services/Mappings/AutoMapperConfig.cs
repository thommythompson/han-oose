using AutoMapper;

namespace HAN.ICDETool.Application.Mappings;

public class AutoMapperConfig
{
    public static IMapper CreateMapper()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<LeerdoelMappingProfile>();
            cfg.AddProfile<LesInrichtingMappingProfile>();
            cfg.AddProfile<LesMateriaalMappingProfile>();
            cfg.AddProfile<LesMateriaalLineMappingProfile>();
        });

        return config.CreateMapper();
    }
}
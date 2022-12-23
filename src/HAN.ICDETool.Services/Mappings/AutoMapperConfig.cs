using AutoMapper;

namespace HAN.ICDETool.Services.Mappings;

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
            cfg.AddProfile<CourseInrichtingMappingProfile>();
            cfg.AddProfile<CourseUitvoeringMappingProfile>();
            cfg.AddProfile<CourseWeekUitvoeringMappingProfile>();
            cfg.AddProfile<LesUitvoeringMappingProfile>();
            cfg.AddProfile<TentamenUitvoeringMappingProfile>();
            cfg.AddProfile<BeoordelingMappingProfile>();
        });

        return config.CreateMapper();
    }
}
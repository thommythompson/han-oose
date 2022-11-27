using HAN.ICDETool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HAN.ICDETool.Infrastructure.Data.Configuration;

public class CourseWeekUitvoeringEntityTypeConfiguration : IEntityTypeConfiguration<CourseWeekUitvoering>
{
    public void Configure(EntityTypeBuilder<CourseWeekUitvoering> builder)
    {
        builder.HasMany(e => e.Lessen)
            .WithOne(e => e.CourseWeekUitvoering)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(e => e.Tentamen)
            .WithOne(e => e.CourseWeekUitvoering)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
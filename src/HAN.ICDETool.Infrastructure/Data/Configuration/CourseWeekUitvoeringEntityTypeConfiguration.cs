using HAN.ICDETool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HAN.ICDETool.Infrastructure.Data.Configuration;

public class CourseWeekUitvoeringEntityTypeConfiguration : IEntityTypeConfiguration<CourseWeekUitvoering>
{
    public void Configure(EntityTypeBuilder<CourseWeekUitvoering> builder)
    {
        // builder.HasOne(e => e.CourseWeekInrichting)
        //     .WithOne()
        //     .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasMany(e => e.Lessen)
            .WithOne()
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasMany(e => e.Tentamen)
            .WithOne()
            .OnDelete(DeleteBehavior.NoAction);
    }
}
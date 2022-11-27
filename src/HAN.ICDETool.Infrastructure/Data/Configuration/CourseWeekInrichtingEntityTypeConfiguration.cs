using HAN.ICDETool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HAN.ICDETool.Infrastructure.Data.Configuration;

public class CourseWeekInrichtingEntityTypeConfiguration : IEntityTypeConfiguration<CourseWeekInrichting>
{
    public void Configure(EntityTypeBuilder<CourseWeekInrichting> builder)
    {
        builder.HasMany(e => e.CourseWeekUitvoeringen)
            .WithOne(e => e.CourseWeekInrichting)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
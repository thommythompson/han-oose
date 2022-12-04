using HAN.ICDETool.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HAN.ICDETool.Infrastructure.Data.Configuration;

public class LesInrichtingEntityTypeConfiguration : IEntityTypeConfiguration<LesInrichting>
{
    public void Configure(EntityTypeBuilder<LesInrichting> builder)
    {
        builder.HasOne(e => e.Leerdoel)
            .WithMany(e => e.GekoppeldeLessen)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
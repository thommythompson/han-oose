using HAN.ICDETool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HAN.ICDETool.Infrastructure.Data.Configuration;

public class RubricsEntityTypeConfiguration : IEntityTypeConfiguration<Rubric>
{
    
    public void Configure(EntityTypeBuilder<Rubric> builder)
    {
        builder.HasOne(e => e.Leerdoel)
            .WithMany(e => e.GekoppeldeRubrics)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
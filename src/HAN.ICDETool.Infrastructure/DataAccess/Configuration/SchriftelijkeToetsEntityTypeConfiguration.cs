using HAN.ICDETool.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HAN.ICDETool.Infrastructure.Data.Configuration;

public class SchriftelijkeToetsEntityTypeConfiguration : IEntityTypeConfiguration<SchriftelijkeToets>
{
    public void Configure(EntityTypeBuilder<SchriftelijkeToets> builder)
    {
        builder.Property(e => e.Type).HasConversion(c => c.ToString(), c => Enum.Parse<TentamenType>(c));
        
        builder.HasOne(e => e.Leerdoel)
            .WithMany(e => e.GekoppeldeToetsen)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
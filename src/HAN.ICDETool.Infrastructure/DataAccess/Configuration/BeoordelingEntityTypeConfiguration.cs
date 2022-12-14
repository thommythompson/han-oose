using HAN.ICDETool.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HAN.ICDETool.Infrastructure.Data.Configuration;

public class BeoordelingEntityTypeConfiguration : IEntityTypeConfiguration<Beoordeling>
{
    public void Configure(EntityTypeBuilder<Beoordeling> builder)
    {
        builder.HasOne(e => e.Docent)
            .WithMany(e => e.BeoordelingenGegeven)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(e => e.Student)
            .WithMany(e => e.BeoordelingenOntvangen)
            .OnDelete(DeleteBehavior.NoAction);
        
        builder.HasOne(e => e.TentamenUitvoering)
            .WithMany(e => e.Beoordelingen)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
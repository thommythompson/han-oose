using HAN.ICDETool.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HAN.ICDETool.Infrastructure.Data.Configuration;

public class LocatieEntityTypeConfiguration : IEntityTypeConfiguration<Locatie>
{
    public void Configure(EntityTypeBuilder<Locatie> builder)
    {
        builder.Property(e => e.LocatieType).HasConversion(c => c.ToString(), c => Enum.Parse<LocatieType>(c));
    }
}
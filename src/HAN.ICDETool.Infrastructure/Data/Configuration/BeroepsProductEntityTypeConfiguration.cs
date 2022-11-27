using HAN.ICDETool.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HAN.ICDETool.Infrastructure.Data.Configuration;

public class BeroepsProductEntityTypeConfiguration : IEntityTypeConfiguration<BeroepsProduct>
{
    public void Configure(EntityTypeBuilder<BeroepsProduct> builder)
    {
        builder.Property(e => e.Type).HasConversion(c => c.ToString(), c => Enum.Parse<TentamenType>(c));
    }
}
using HAN.ICDETool.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HAN.ICDETool.Infrastructure.Data.Configuration;

public class PersoonEntityTypeConfiguration : IEntityTypeConfiguration<Persoon>
{
    public void Configure(EntityTypeBuilder<Persoon> builder)
    {
        builder.HasMany(e => e.BeoordelingenGegeven)
            .WithOne(e => e.Docent)
            .HasForeignKey(b => b.DocentId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(e => e.BeoordelingenOntvangen)
            .WithOne(e => e.Student)
            .HasForeignKey(b => b.StudentId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(e => e.DocentVoorLesUitvoeringen)
            .WithOne(e => e.Docent)
            .HasForeignKey(l => l.DocentId);

        builder.HasMany(e => e.DocentVoorTentamenUitvoeringen)
            .WithOne(e => e.Docent)
            .HasForeignKey(t => t.DocentId);

        builder.HasOne(e => e.VolgtProfiel)
            .WithMany(e => e.GevolgdDoor)
            .HasForeignKey(p => p.VolgtProfileId);
        
        builder.HasOne(e => e.VolgtCourse)
            .WithMany(e => e.Studenten)
            .HasForeignKey(p => p.VolgtCourseId);
        
        builder.HasOne(e => e.ZitInKlas)
            .WithMany(e => e.Studenten)
            .HasForeignKey(p => p.ZitInKlasId);
        
        builder.HasOne(e => e.MentorVanKlas)
            .WithOne(e => e.Mentor)
            .HasForeignKey<Persoon>(p => p.MentorVanKlasId);
    }
}
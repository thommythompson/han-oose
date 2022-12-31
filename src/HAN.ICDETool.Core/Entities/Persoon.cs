using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class Persoon : IdentityUser<int>, BaseEntity
{
    [PersonalData]
    public string Voornaam { get; set; }
    [PersonalData]
    public string Achternaam { get; set; }

    public OpleidingsProfiel? VolgtProfiel { get; set; }
    public int? VolgtProfileId { get; set; }
    public CourseUitvoering? VolgtCourse { get; set; }
    public int? VolgtCourseId { get; set; }
    public Klas? ZitInKlas { get; set; }
    public int? ZitInKlasId { get; set; }
    public Klas? MentorVanKlas { get; set; }
    public int? MentorVanKlasId { get; set; }
    
    [BackingField(nameof(_beoordelingenOntvangen))]
    public IReadOnlyList<Beoordeling>? BeoordelingenOntvangen { get => _beoordelingenOntvangen; }

    public List<Beoordeling>? _beoordelingenOntvangen { get; set; } = new();
    [BackingField(nameof(_beoordelingenGegeven))]
    public IReadOnlyList<Beoordeling>? BeoordelingenGegeven { get => _beoordelingenGegeven; }
    public List<Beoordeling>? _beoordelingenGegeven { get; set; } = new();
    
    // Onderstaande properties hebben geen backing field omdat EF dit niet ondersteund voor de gedefineerde relaties.
    public IList<LesUitvoering>? DocentVoorLesUitvoeringen { get; set; } = new List<LesUitvoering>();
    public IList<TentamenUitvoering>? DocentVoorTentamenUitvoeringen { get; set; } = new List<TentamenUitvoering>();
    
    public Persoon(string voornaam, string achternaam, string email)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        base.Email = email;
        base.UserName = email;
    }
}
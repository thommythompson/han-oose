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
    
    public IList<Beoordeling>? BeoordelingenOntvangen { get; set; } = new List<Beoordeling>();
    public IList<Beoordeling>? BeoordelingenGegeven { get; set; } = new List<Beoordeling>();
    public IList<LesUitvoering> DocentVoorLesUitvoeringen { get; set; } = new List<LesUitvoering>();
    public IList<TentamenUitvoering>? DocentVoorTentamenUitvoeringen { get; set; } = new List<TentamenUitvoering>();
    
    public Persoon(string voornaam, string achternaam, string email)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        base.Email = email;
        base.UserName = email;
    }
    
    
    
}
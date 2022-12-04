using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class Student : Persoon, BaseEntity
{
    public int Id { get; set; }
    public string Voornaam { get; set; }
    public string Achternaam { get; set; }
    public string Email { get; set; }
    public OpleidingsProfiel? VolgtProfiel { get; set; }
    public int? OpleidingsProfielId { get; set; }
    public CourseUitvoering? VolgCourse { get; set; }
    public int? CourseUitvoeringId { get; set; }
    [BackingField(nameof(_beoordelingen))]
    public IEnumerable<Beoordeling>? Beoordelingen { get => _beoordelingen ;}

    private IList<Beoordeling>? _beoordelingen { get; set; } = new List<Beoordeling>();
    public int? KlasId { get; set; }
    
    public Student(string voornaam, string achternaam, string email)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        this.Email = email;
    }
}
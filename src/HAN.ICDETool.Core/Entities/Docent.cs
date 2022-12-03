using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class Docent : Persoon
{
    public int Id { get; set; }
    public string Voornaam { get; set; }
    public string Achternaam { get; set; }
    public string Email { get; set; }
    [BackingField(nameof(_beoordelingen))]
    public IEnumerable<Beoordeling>? Beoordelingen { get => _beoordelingen ;}

    private IList<Beoordeling>? _beoordelingen { get; set; } = new List<Beoordeling>();
    [BackingField(nameof(_LesUitvoeringen))]
    public IEnumerable<LesUitvoering>? LesUitvoeringen { get => _LesUitvoeringen; }

    private IList<LesUitvoering>? _LesUitvoeringen { get; set; } = new List<LesUitvoering>();
    [BackingField(nameof(_tentamenUitvoeringen))]
    public IEnumerable<TentamenUitvoering>? TentamenUitvoeringen { get => _tentamenUitvoeringen; }

    private IList<TentamenUitvoering>? _tentamenUitvoeringen { get; set; } = new List<TentamenUitvoering>();
    public Klas? MentorVan { get; set; }

    public Docent(string voornaam, string achternaam, string email)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        this.Email = email;
    }
}
namespace HAN.ICDETool.Domain;

public class Docent : Persoon
{
    public int Id { get; set; }
    public string Voornaam { get; set; }
    public string Achternaam { get; set; }
    public string Email { get; set; }
    public IEnumerable<Beoordeling> Beoordelingen { get => _beoordelingen ;}
    private IList<Beoordeling> _beoordelingen { get; set; }
    public IEnumerable<LesUitvoering> LesUitvoeringen { get => _LesUitvoeringen; }
    private IList<LesUitvoering> _LesUitvoeringen { get; set; }
    public IEnumerable<TentamenUitvoering> TentamenUitvoeringen { get => _tentamenUitvoeringen; }
    private IList<TentamenUitvoering> _tentamenUitvoeringen { get; set; }

    public Docent(string voornaam, string achternaam, string email)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        this.Email = email;
    }
}
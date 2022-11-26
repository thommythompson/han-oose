namespace HAN.ICDETool.Domain;

public class SchriftelijkeToets : TentamenInrichting, Validator
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public TentamenType Type { get; set; }
    public int Weging { get; set; }
    public int TeBehalenStudiepunten { get; set; }
    public int CourseWeekInrichtingId { get; set; }
    public int LeerdoelId { get; set; }
    public IEnumerable<TentamenUitvoering> TentamenUitvoeringen { get => _tentamenUitvoeringen; }
    private IList<TentamenUitvoering> _tentamenUitvoeringen { get; set; }

    public SchriftelijkeToets(string titel)
    {
        this.Titel = titel;
    }

    public void validate()
    {
        throw new NotImplementedException();
    }
}
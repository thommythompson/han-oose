namespace HAN.ICDETool.Domain;

public class SchriftelijkeToets : TentamenInrichting
{
    public string? Titel { get; private set; }
    public TentamenType? Type { get; private set; }
    public int? Weging { get; private set; }
    public int? TeBehalenStudiepunten { get; private set; }
    private IList<Leerdoel> Leerdoels { get; set; }

    public SchriftelijkeToets(String titel, CourseWeekInrichting week)
    {
        Titel = titel;
        week.VoegTentamenToe(this);
    }
}
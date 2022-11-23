namespace HAN.ICDETool.Domain;

public class LesInrichting
{
    
    public int Id { get; set; }
    private String? _titel { get; set; }
    public IList<LesMateriaal>? LesMateriaal { get; set; }
    private IList<Leerdoel>? _leerdoelen { get; set; }

    public LesInrichting(String titel, CourseWeekInrichting week)
    {
        _titel = titel;
        week.voegLesToe(this);
    }

    public void VoegMateriaalToe(string titel, string inhoud)
    {
        LesMateriaal.Add(new LesMateriaal(titel, inhoud));
    }
}
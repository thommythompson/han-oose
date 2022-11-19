namespace HAN.ICDETool.Domain;

public class LesInrichting
{
    private String? _titel { get; set; }
    private IList<LesMateriaal>? _lesMateriaal { get; set; }
    private IList<Leerdoel>? _leerdoelen { get; set; }

    public LesInrichting(String titel, CourseWeekInrichting week)
    {
        _titel = titel;
        week.voegLesToe(this);
    }
}
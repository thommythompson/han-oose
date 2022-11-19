namespace HAN.ICDETool.Domain;

public class CourseInrichting
{
    public String? Titel { get; private set; }
    private String? _omschrijving { get; set; }
    public CourseWeekPlanning? Planning { get; private set; }

    private IList<EenheidVanLeeruitkomsten> _evls { get; set; } = new List<EenheidVanLeeruitkomsten>();
    private IList<TentamenInrichting> _tentamen { get; set; } = new List<TentamenInrichting>();
    private IList<LesInrichting> _lessen { get; set; } = new List<LesInrichting>();
    private bool _isDefintief { get; set; } = false;
    private Persoon? _gemaaktDoor { get; set; }

    public CourseInrichting(String titel, ITijdDefinitie duur)
    {
        Titel = titel;
        
        Planning = new CourseWeekPlanning(duur);
    }

    public void maakDefintief()
    {
        _isDefintief = true;
    }
    
    public void VoegTentamenToe(String titel, CourseWeekInrichting week)
    {
        _tentamen.Add(new BeroepsProduct(titel, week));
        _tentamen.Add(new SchriftelijkeToets(titel, week));
    }

    public void VoegLesToe(String titel, CourseWeekInrichting week)
    {
        _lessen.Add(new LesInrichting(titel, week));
    }
    
    public CourseUitvoering StartCourseUitvoering(DateOnly date)
    {
        if (!_isDefintief)
            throw new Exception("Kan geen uitvoering starten van een course inrichting die niet defintief is.");
        
        return new CourseUitvoering(this, date);
    }
}
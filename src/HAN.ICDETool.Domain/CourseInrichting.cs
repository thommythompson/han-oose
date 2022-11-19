namespace HAN.ICDETool.Domain;

public class CourseInrichting
{
    public String? Titel { get; private set; }
    private String? _omschrijving { get; set; }
    private ITijdDefinitie? _duur { get; set; }
    private CourseWeekPlanning? _planning { get; set; }
    private EenheidVanLeeruitkomsten _evls { get; set; }
    private bool? _isDefintief { get; set; }
    private Persoon? _gemaaktDoor { get; set; }

    public CourseInrichting(String titel)
    {
        this.Titel = titel;
    }
}
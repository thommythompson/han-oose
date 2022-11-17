namespace HAN.ICDETool.Domain;

public class CourseInrichting
{
    public String? titel { get; private set; }
    private String? omschrijving { get; set; }
    private ITijdDefinitie? duur { get; set; }
    private CourseWeekPlanning? planning { get; set; }
    private EenheidVanLeeruitkomsten evls { get; set; }
    private bool? isDefintief { get; set; }

    public CourseInrichting(String titel)
    {
        this.titel = titel;
    }
}
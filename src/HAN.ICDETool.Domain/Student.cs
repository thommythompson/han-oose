namespace HAN.ICDETool.Domain;

public class Student : Persoon
{
    public string? Voornaam { get; }
    public string? Achternaam { get; }
    public string? Email { get; }
    private OpleidingsProfiel? _volgtProfiel { get; set; }
    private CourseUitvoering? _volgtCourse { get; set; }
}
namespace HAN.ICDETool.Domain;

public class Student : Persoon
{
    public int Id { get; set; }
    public string Voornaam { get; init; }
    public string Achternaam { get; init; }
    public string Email { get; init; }
    public OpleidingsProfiel VolgtProfiel { get; set; }
    public CourseUitvoering VolgCourse { get; set; }
}
namespace HAN.ICDETool.Domain;

public class Student : Persoon
{
    public int Id { get; set; }
    public string Voornaam { get; set; }
    public string Achternaam { get; set; }
    public string Email { get; set; }
    public OpleidingsProfiel VolgtProfiel { get; set; }
    public CourseUitvoering VolgCourse { get; set; }
    
    public Student(string voornaam, string achternaam, string email)
    {
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        this.Email = email;
    }
}
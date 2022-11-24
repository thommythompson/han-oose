namespace HAN.ICDETool.Domain;

public class Docent : Persoon
{
    public int Id { get; set; }
    public string Voornaam { get; init; }
    public string Achternaam { get; init; }
    public string Email { get; init; }
}
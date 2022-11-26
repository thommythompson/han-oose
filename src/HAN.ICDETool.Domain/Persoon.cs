using System.Runtime.Versioning;

namespace HAN.ICDETool.Domain;

public interface Persoon
{
    public string Voornaam { get; set; }
    public string Achternaam { get; set; }
    public string Email { get; set; }
}
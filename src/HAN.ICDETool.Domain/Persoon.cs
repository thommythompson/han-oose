using System.Runtime.Versioning;

namespace HAN.ICDETool.Domain;

public interface Persoon
{
    public string Voornaam { get; init; }
    public string Achternaam { get; init; }
    public string Email { get; init; }
}
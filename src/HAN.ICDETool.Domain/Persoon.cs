using System.Runtime.Versioning;

namespace HAN.ICDETool.Domain;

public interface Persoon
{
    public String? Voornaam { get; }
    public String? Achternaam { get; }
    public String? Email { get; }
}
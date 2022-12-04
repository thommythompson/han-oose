namespace HAN.ICDETool.Core.Entities;

public interface Persoon : BaseEntity
{
    public string Voornaam { get; set; }
    public string Achternaam { get; set; }
    public string Email { get; set; }
}
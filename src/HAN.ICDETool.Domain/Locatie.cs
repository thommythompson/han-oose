namespace HAN.ICDETool.Domain;

public class Locatie
{
    public int Id { get; set; }
    public string Naam { get; init; }
    public LocatieType LocatieType { get; init; }
    public Adres? Adres { get; set; }

    public Locatie(string naam, LocatieType locatieType)
    {
        this.Naam = naam;
        this.LocatieType = locatieType;
    }
}
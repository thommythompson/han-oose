namespace HAN.ICDETool.Domain;

public class Locatie
{
    public int Id { get; set; }
    public string Naam { get; init; }
    public LocatieType Type { get; init; }
    public Adres? Adres { get; set; }
}
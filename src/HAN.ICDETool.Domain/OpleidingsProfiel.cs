namespace HAN.ICDETool.Domain;

public class OpleidingsProfiel
{
    public int Id { get; set; }
    public string Naam { get; set; }
    public string Code { get; set; }

    public OpleidingsProfiel(string naam, string code)
    {
        this.Naam = naam;
        this.Code = code;
    }
}
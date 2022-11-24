namespace HAN.ICDETool.Domain;

public class Opleiding
{
    public int Id { get; set; }
    public String Naam { get; init; }
    private String Code { get; init; }
    private IList<OpleidingsProfiel> OpleidingsProfielen { get; } = new List<OpleidingsProfiel>();

    public void AddOpleidingsProfiel(OpleidingsProfiel profiel)
    {
        OpleidingsProfielen.Add(profiel);
    }

    public void RemoveOpleidingsProfiel(OpleidingsProfiel profiel)
    {
        OpleidingsProfielen.Remove(profiel);
    }
}
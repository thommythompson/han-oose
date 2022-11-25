using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class Opleiding
{
    public int Id { get; set; }
    public String Naam { get; init; }
    public String Code { get; init; }
    
    [NotMapped]
    public IEnumerable<OpleidingsProfiel> OpleidingsProfielen { get => _opleidingsProfielen;} 
    private IList<OpleidingsProfiel> _opleidingsProfielen { get; } = new List<OpleidingsProfiel>();

    public void AddOpleidingsProfiel(OpleidingsProfiel profiel)
    {
        _opleidingsProfielen.Add(profiel);
    }

    public void RemoveOpleidingsProfiel(OpleidingsProfiel profiel)
    {
        _opleidingsProfielen.Remove(profiel);
    }
}
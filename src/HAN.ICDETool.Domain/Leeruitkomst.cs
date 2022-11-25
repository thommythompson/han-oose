using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class Leeruitkomst
{
    public int Id { get; set; }
    public string Titel { get; init; }
    public string Omschrijving { get; init; }
    
    [NotMapped]
    public IEnumerable<Leerdoel> Leerdoelen { get => _leerdoelen; }
    private IList<Leerdoel> _leerdoelen { get; } = new List<Leerdoel>();

    public void KoppelLeerdoel(Leerdoel leerdoel)
    {
        _leerdoelen.Add(leerdoel);
    }
}
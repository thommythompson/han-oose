using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class Leeruitkomst : BaseEntity
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public string Omschrijving { get; set; }
    [BackingField(nameof(_leerdoelen))]
    public IEnumerable<Leerdoel>? Leerdoelen { get => _leerdoelen; }
    private IList<Leerdoel>? _leerdoelen { get; } = new List<Leerdoel>();
    public int EenheidVanLeeruitkomstenId { get; set; }

    public Leeruitkomst(string titel, string omschrijving)
    {
        this.Titel = titel;
        this.Omschrijving = omschrijving;
    }
    
    public void KoppelLeerdoel(Leerdoel leerdoel)
    {
        _leerdoelen.Add(leerdoel);
    }
    
    public void OntkoppelLeerdoel(Leerdoel leerdoel)
    {
        _leerdoelen.Remove(leerdoel);
    }
}
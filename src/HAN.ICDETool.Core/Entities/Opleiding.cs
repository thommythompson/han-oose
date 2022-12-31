using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class Opleiding : BaseEntity
{
    public int Id { get; set; }
    public String Naam { get; set; }
    public String Code { get; set; }
    [BackingField(nameof(_opleidingsProfielen))]
    public IReadOnlyList<OpleidingsProfiel>? OpleidingsProfielen { get => _opleidingsProfielen;} 
    private List<OpleidingsProfiel>? _opleidingsProfielen { get; } = new List<OpleidingsProfiel>();

    public Opleiding(string naam, string code)
    {
        this.Naam = naam;
        this.Code = code;
    }
    
    public void AddOpleidingsProfiel(OpleidingsProfiel profiel)
    {
        _opleidingsProfielen.Add(profiel);
    }

    public void RemoveOpleidingsProfiel(OpleidingsProfiel profiel)
    {
        _opleidingsProfielen.Remove(profiel);
    }
}
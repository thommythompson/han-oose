using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class OpleidingsProfiel : BaseEntity
{
    public int Id { get; set; }
    public string Naam { get; set; }
    public string Code { get; set; }
    public int OpleidingId { get; set; }
    [BackingField(nameof(_gevolgdDoor))]
    public IEnumerable<Persoon>? GevolgdDoor { get => _gevolgdDoor; }

    private IList<Persoon>? _gevolgdDoor { get; set; } = new List<Persoon>();

    public OpleidingsProfiel(string naam, string code)
    {
        this.Naam = naam;
        this.Code = code;
    }
}
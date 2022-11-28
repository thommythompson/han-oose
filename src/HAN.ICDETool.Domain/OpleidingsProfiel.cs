using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Domain;

public class OpleidingsProfiel
{
    public int Id { get; set; }
    public string Naam { get; set; }
    public string Code { get; set; }
    public int OpleidingId { get; set; }
    [BackingField(nameof(_gevolgdDoor))]
    public IEnumerable<Student>? GevolgdDoor { get => _gevolgdDoor; }

    private IList<Student>? _gevolgdDoor { get; set; } = new List<Student>();

    public OpleidingsProfiel(string naam, string code)
    {
        this.Naam = naam;
        this.Code = code;
    }
}
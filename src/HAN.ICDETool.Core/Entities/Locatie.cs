using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class Locatie : BaseEntity
{
    public int Id { get; set; }
    public string Naam { get; init; }
    public LocatieType LocatieType { get; init; }
    public Adres? Adres { get; set; }
    
    [BackingField(nameof(_LesUitvoeringen))]
    public IReadOnlyList<LesUitvoering>? LesUitvoeringen { get => _LesUitvoeringen; }

    private List<LesUitvoering>? _LesUitvoeringen { get; set; } = new List<LesUitvoering>();
    
    [BackingField(nameof(_tentamenUitvoeringen))]
    public IReadOnlyList<TentamenUitvoering>? TentamenUitvoeringen { get => _tentamenUitvoeringen; }

    private List<TentamenUitvoering>? _tentamenUitvoeringen { get; set; } = new List<TentamenUitvoering>();

    public Locatie(string naam, LocatieType locatieType)
    {
        this.Naam = naam;
        this.LocatieType = locatieType;
    }
}
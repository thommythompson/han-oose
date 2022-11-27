using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Domain;

public class Locatie
{
    public int Id { get; set; }
    public string Naam { get; init; }
    public LocatieType LocatieType { get; init; }
    public Adres? Adres { get; set; }
    
    [BackingField(nameof(_LesUitvoeringen))]
    public IEnumerable<LesUitvoering> LesUitvoeringen { get => _LesUitvoeringen; }
    private IList<LesUitvoering> _LesUitvoeringen { get; set; }
    
    [BackingField(nameof(_tentamenUitvoeringen))]
    public IEnumerable<TentamenUitvoering> TentamenUitvoeringen { get => _tentamenUitvoeringen; }
    private IList<TentamenUitvoering> _tentamenUitvoeringen { get; set; }

    public Locatie(string naam, LocatieType locatieType)
    {
        this.Naam = naam;
        this.LocatieType = locatieType;
    }
}
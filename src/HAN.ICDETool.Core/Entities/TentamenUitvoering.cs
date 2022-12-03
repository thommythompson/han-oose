using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class TentamenUitvoering
{
    public int Id { get; set; }
    public SchriftelijkeToets? SchriftelijkeToets { get; init; }
    public int? SchriftelijkeToetsId { get; init; }
    public BeroepsProduct? BeroepsProduct { get; init; }
    public int? BeroepsProductId { get; init; }
    public Locatie? Locatie { get; set; }
    public int? LocatieId { get; set; }
    public Docent? Docent { get; set; }
    public int? DocentId { get; set; }
    public CourseWeekUitvoering CourseWeekUitvoering { get; set; }
    public int CourseUitvoeringId { get; set; }
    [BackingField(nameof(_beoordelingen))]
    public IEnumerable<Beoordeling> Beoordelingen { get => _beoordelingen ;}

    private IList<Beoordeling> _beoordelingen { get; set; } = new List<Beoordeling>();

    // EF Core constructor: EF Core does not support navigation types in the constructor
    private TentamenUitvoering() { }

    public TentamenUitvoering(SchriftelijkeToets schriftelijkeToets) : this()
    {
        this.SchriftelijkeToets = schriftelijkeToets;
    }
    
    public TentamenUitvoering(BeroepsProduct beroepsProduct) : this()
    {
        this.BeroepsProduct = beroepsProduct;
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class TentamenUitvoering
{
    public int Id { get; set; }
    public SchriftelijkeToets? SchriftelijkeToets { get; init; }
    public BeroepsProduct? BeroepsProduct { get; init; }
    public Locatie? Locatie { get; set; }
    public Docent? Docent { get; set; }

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
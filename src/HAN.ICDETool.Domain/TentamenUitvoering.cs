using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class TentamenUitvoering
{
    public int Id { get; set; }
    public SchriftelijkeToets? SchriftelijkeToets { get; set; }
    public BeroepsProduct? BeroepsProduct { get; init; }
    public Locatie? Locatie { get; set; }
    public Docent? Docent { get; set; }
}
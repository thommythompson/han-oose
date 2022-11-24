using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class TentamenUitvoering
{
    public int Id { get; set; }
    
    // TODO: Mapping TentamenInrichting to data object in infrastructure?
    [NotMapped]
    public TentamenInrichting TentamenInrichting { get; init; }
    public Locatie? Locatie { get; set; }
    public Docent? Docent { get; set; }
}
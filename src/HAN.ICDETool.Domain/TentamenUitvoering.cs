namespace HAN.ICDETool.Domain;

public class TentamenUitvoering
{
    private DateTimeOffset? _datum { get; set; }
    private TentamenInrichting _inrichting { get; set; }
    private Locatie _locatie { get; set; }
    private Persoon? _docent { get; set; }    
}
namespace HAN.ICDETool.Domain;

public class Beoordeling
{
    private TentamenUitvoering? _tentamen { get; set; }
    private Persoon? _beoordelingVoor { get; set; }
    private Persoon? _beoordeeldDoor { get; set; }
}
namespace HAN.ICDETool.Domain;

public class BeroepsProduct : TentamenInrichting
{
    public string? titel { get; private set; }
    public TentamenType? type { get; private set; }
    public int? weging { get; private set; }
    public int? teBehalenStudiepunten { get; private set; }
}
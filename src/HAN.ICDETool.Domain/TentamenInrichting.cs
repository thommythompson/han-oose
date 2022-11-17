namespace HAN.ICDETool.Domain;

public interface TentamenInrichting
{
    public String? titel { get; }
    public TentamenType? type { get; }
    public int? weging { get; }
    public int? teBehalenStudiepunten { get; }
}
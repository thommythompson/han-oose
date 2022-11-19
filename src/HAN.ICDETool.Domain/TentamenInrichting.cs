namespace HAN.ICDETool.Domain;

public interface TentamenInrichting
{
    public String? Titel { get; }
    public TentamenType? Type { get; }
    public int? Weging { get; }
    public int? TeBehalenStudiepunten { get; }
}
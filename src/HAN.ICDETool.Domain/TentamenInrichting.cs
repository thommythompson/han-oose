namespace HAN.ICDETool.Domain;

public interface TentamenInrichting
{
    public int Id { get; set; }
    public string Titel { get; init; }
    public TentamenType Type { get; init; }
    public int Weging { get; init; }
    public int TeBehalenStudiepunten { get; init; }
}
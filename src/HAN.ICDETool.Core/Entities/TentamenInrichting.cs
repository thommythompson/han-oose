namespace HAN.ICDETool.Core.Entities;

public interface TentamenInrichting
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public TentamenType Type { get; set; }
    public int Weging { get; set; }
    public int TeBehalenStudiepunten { get; set; }
}
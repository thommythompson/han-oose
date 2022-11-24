namespace HAN.ICDETool.Domain;

public class Periode : ITijdDefinitie
{
    public int Id { get; set; }
    public int DuurInWeken { get => 10; }
    public int TeBehalenStudiepunten { get => 15; }
}
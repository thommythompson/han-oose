namespace HAN.ICDETool.Core.Entities;

public class Periode : ITijdDefinitie, BaseEntity
{
    public int Id { get; set; }
    public int DuurInWeken { get => 10; }
    public int TeBehalenStudiepunten { get => 15; }
}
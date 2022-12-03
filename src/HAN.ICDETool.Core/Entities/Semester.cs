namespace HAN.ICDETool.Core.Entities;

public class Semester : ITijdDefinitie
{
    public int Id { get; set; }
    public int DuurInWeken { get => 20; }
    public int TeBehalenStudiepunten { get => 30;  }
}
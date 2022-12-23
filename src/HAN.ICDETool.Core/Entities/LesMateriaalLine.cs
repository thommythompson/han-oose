namespace HAN.ICDETool.Core.Entities;

public class LesMateriaalLine : BaseEntity
{
    public int Id { get; set; }
    public string Line { get; set; }
    public int LesMateriaalId { get; set; }

    public LesMateriaalLine(string line)
    {
        this.Line = line;
    }
}
namespace HAN.ICDETool.Core.Entities;

public class LesMateriaalLine
{
    public int Id { get; set; }
    public string Line { get; set; }
    public int LesMateriaalLineId { get; set; }

    public LesMateriaalLine(string line)
    {
        this.Line = line;
    }
}
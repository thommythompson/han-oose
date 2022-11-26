namespace HAN.ICDETool.Domain;

public class LesMateriaalLine
{
    public int Id { get; set; }
    public string Line { get; set; }

    public LesMateriaalLine(string line)
    {
        this.Line = line;
    }
}
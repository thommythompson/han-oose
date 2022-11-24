namespace HAN.ICDETool.Domain;

public class LesUitvoering
{
    public int Id { get; set; }
    public LesInrichting LesInrichting { get; init; }
    public Docent? Docent { get; set; }
    public Locatie? Locatie { get; set; }
}
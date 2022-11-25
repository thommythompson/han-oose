namespace HAN.ICDETool.Domain;

public class LesUitvoering
{
    public int Id { get; set; }
    public LesInrichting LesInrichting { get; }
    public Docent? Docent { get; set; }
    public Locatie? Locatie { get; set; }

    public LesUitvoering(LesInrichting lesInrichting)
    {
        this.LesInrichting = lesInrichting;
    }
}
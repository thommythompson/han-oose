namespace HAN.ICDETool.Domain;

public class LesUitvoering
{
    public int Id { get; set; }
    public LesInrichting LesInrichting { get; }
    public Docent? Docent { get; set; }
    public Locatie? Locatie { get; set; }

    // EF Core constructor: EF Core does not support navigation types in the constructor
    private LesUitvoering() { }

    public LesUitvoering(LesInrichting lesInrichting) : this()
    {
        this.LesInrichting = lesInrichting;
    }
}
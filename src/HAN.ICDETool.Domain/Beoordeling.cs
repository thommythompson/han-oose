namespace HAN.ICDETool.Domain;

public class Beoordeling
{
    public int Id { get; set; }
    public TentamenUitvoering TentamenUitvoering { get; set; }
    public int TentamenUitvoeringId { get; set; }
    public Student BeoordelingVoor { get; set; }
    public int StudentId { get; set; }
    public Docent BeoordeeldDoor { get; set; }
    public int DocentId { get; set; }

    // EF Core constructor: EF Core does not support navigation types in the constructor
    private Beoordeling() { }

    public Beoordeling(TentamenUitvoering tentamenUitvoering, Student beoordelingVoor, Docent beoordeeldDoor) : this()
    {
        this.TentamenUitvoering = tentamenUitvoering;
        this.BeoordelingVoor = beoordelingVoor;
        this.BeoordeeldDoor = beoordeeldDoor;
    }
}
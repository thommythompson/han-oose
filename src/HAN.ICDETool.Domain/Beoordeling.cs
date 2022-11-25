namespace HAN.ICDETool.Domain;

public class Beoordeling
{
    public int Id { get; set; }
    public TentamenUitvoering TentamenUitvoering { get; init; }
    public Student BeoordelingVoor { get; init; }
    public Docent BeoordeeldDoor { get; init; }

    public Beoordeling(TentamenUitvoering tentamenUitvoering, Student beoordelingVoor, Docent beoordeeldDoor)
    {
        this.TentamenUitvoering = tentamenUitvoering;
        this.BeoordelingVoor = beoordelingVoor;
        this.BeoordeeldDoor = beoordeeldDoor;
    }
}
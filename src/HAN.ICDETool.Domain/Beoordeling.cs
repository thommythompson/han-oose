namespace HAN.ICDETool.Domain;

public class Beoordeling
{
    public int Id { get; set; }
    public TentamenUitvoering Tentamen { get; init; }
    public Student BeoordelingVoor { get; init; }
    public Docent BeoordeeldDoor { get; init; }
}
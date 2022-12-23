namespace HAN.ICDETool.Core.Entities;

public class Beoordeling : BaseEntity
{
    public int Id { get; set; }
    public TentamenUitvoering TentamenUitvoering { get; set; }
    public int TentamenUitvoeringId { get; set; }
    public Persoon Student { get; set; }
    public int StudentId { get; set; }
    public Persoon Docent { get; set; }
    public int DocentId { get; set; }

    // EF Core constructor: EF Core does not support navigation types in the constructor
    private Beoordeling() { }

    public Beoordeling(TentamenUitvoering tentamenUitvoering, Persoon student, Persoon docent) : this()
    {
        this.TentamenUitvoering = tentamenUitvoering;
        this.Student = student;
        this.Docent = docent;
    }
}
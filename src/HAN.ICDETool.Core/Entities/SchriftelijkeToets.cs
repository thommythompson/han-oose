using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class SchriftelijkeToets : TentamenInrichting, Validator, BaseEntity
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public TentamenType Type { get; set; }
    public int Weging { get; set; }
    public int TeBehalenStudiepunten { get; set; }
    public int? CourseWeekInrichtingId { get; set; }
    public int CourseInrichtingId { get; set; }
    public Leerdoel Leerdoel { get; set; }
    public int LeerdoelId { get; set; }
    [BackingField(nameof(_tentamenUitvoeringen))]
    public IReadOnlyList<TentamenUitvoering>? TentamenUitvoeringen { get => _tentamenUitvoeringen; }
    private List<TentamenUitvoering>? _tentamenUitvoeringen { get; set; } = new List<TentamenUitvoering>();

    private SchriftelijkeToets(string titel)
    {
        this.Titel = titel;
    }
    public SchriftelijkeToets(string titel, Leerdoel leerdoel) : this(titel)
    {
        this.Leerdoel = leerdoel;
    }

    public void validate()
    {
        throw new NotImplementedException();
    }
}
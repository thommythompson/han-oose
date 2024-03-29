using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class BeroepsProduct : BaseEntity, TentamenInrichting
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public TentamenType Type { get; set; }
    public int Weging { get; set; }
    public int TeBehalenStudiepunten { get; set; }
    [BackingField(nameof(_rubrics))]
    public IReadOnlyList<Rubric>? Rubrics { get => _rubrics; }
    private List<Rubric>? _rubrics { get; } = new List<Rubric>();
    [BackingField(nameof(_tentamenUitvoeringen))]
    public IReadOnlyList<TentamenUitvoering>? TentamenUitvoeringen { get => _tentamenUitvoeringen; }
    private List<TentamenUitvoering>? _tentamenUitvoeringen { get; set; } = new List<TentamenUitvoering>();
    public int CourseInrichtingId { get; set; }
    public int? CourseWeekInrichtingId { get; set; }

    public BeroepsProduct(string titel)
    {
        this.Titel = titel;
    }

    public void AddRubric(Rubric rubric)
    {
        _rubrics.Add(rubric);
    }

    public void RemoveRubric(Rubric rubric)
    {
        _rubrics.Remove(rubric);
    }
}
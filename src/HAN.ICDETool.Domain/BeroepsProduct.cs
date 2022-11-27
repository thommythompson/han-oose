using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Domain;

public class BeroepsProduct : TentamenInrichting
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public TentamenType Type { get; set; }
    public int Weging { get; set; }
    public int TeBehalenStudiepunten { get; set; }
    [BackingField(nameof(_rubrics))]
    public IEnumerable<Rubric> Rubrics { get => _rubrics; }
    private IList<Rubric> _rubrics { get; } = new List<Rubric>();
    [BackingField(nameof(_tentamenUitvoeringen))]
    public IEnumerable<TentamenUitvoering> TentamenUitvoeringen { get => _tentamenUitvoeringen; }

    private IList<TentamenUitvoering> _tentamenUitvoeringen { get; set; } = new List<TentamenUitvoering>();
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
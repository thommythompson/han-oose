using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class BeroepsProduct : TentamenInrichting
{
    public int Id { get; set; }
    public string Titel { get; init; }
    public TentamenType Type { get; init; }
    public int Weging { get; init; }
    public int TeBehalenStudiepunten { get; init; }
    // public CourseWeekInrichting? CourseWeekInrichting { get; private set; }
    
    [NotMapped]
    public IEnumerable<Rubric> Rubrics { get => _rubrics; }
    private IList<Rubric> _rubrics { get; } = new List<Rubric>();
    
    public void AddRubric(Rubric rubric)
    {
        _rubrics.Add(rubric);
    }
}
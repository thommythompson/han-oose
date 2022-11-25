using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class BeroepsProduct : TentamenInrichting
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public TentamenType Type { get; set; }
    public int Weging { get; set; }
    public int TeBehalenStudiepunten { get; set; }
    public IEnumerable<Rubric> Rubrics { get => _rubrics; }
    private IList<Rubric> _rubrics { get; } = new List<Rubric>();

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
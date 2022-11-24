namespace HAN.ICDETool.Domain;

public class BeroepsProduct : TentamenInrichting
{
    public int Id { get; set; }
    public string Titel { get; init; }
    public TentamenType Type { get; init; }
    public int Weging { get; init; }
    public int TeBehalenStudiepunten { get; init; }
    public IList<Rubric> Rubrics { get; private set; } = new List<Rubric>();
    public CourseWeekInrichting? CourseWeekInrichting { get; private set; }
    
    public void AddRubric(Rubric rubric)
    {
        Rubrics.Add(rubric);
    }

    public void WijsToeAanWeek(CourseWeekInrichting courseWeekInrichting)
    {
        courseWeekInrichting.AddTentamen(this);
    }
}
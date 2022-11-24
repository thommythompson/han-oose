namespace HAN.ICDETool.Domain;

public class CourseWeekInrichting
{
    public int Id { get; set; }
    public IList<TentamenInrichting> Tentamen { get; } = new List<TentamenInrichting>();
    public IList<LesInrichting> Lessen { get; } = new List<LesInrichting>();

    public void AddTentamen(TentamenInrichting tentamen)
    {
        Tentamen.Add(tentamen);
    }
    public void AddLes(LesInrichting les)
    {
        Lessen.Add(les);
    }
}
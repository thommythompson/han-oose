namespace HAN.ICDETool.Domain;

public class CourseWeekInrichting
{
    public IList<TentamenInrichting>? Tentamen { get; private set; } = new List<TentamenInrichting>();
    public IList<LesInrichting>? Lessen { get; private set; } = new List<LesInrichting>();

    public void VoegTentamenToe(TentamenInrichting tentamen)
    {
        Tentamen.Add(tentamen);
    }

    public void voegLesToe(LesInrichting les)
    {
        Lessen.Add(les);
    }
}
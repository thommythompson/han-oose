namespace HAN.ICDETool.Domain;

public class LesInrichting
{
    public int Id { get; set; }
    public string Titel { get; init; }
    public IList<LesMateriaal> LesMateriaal { get; } = new List<LesMateriaal>();

    public void AddLesMateriaal(LesMateriaal lesMateriaal)
    {
        LesMateriaal.Add(lesMateriaal);
    }

    public void RemoveLesMateriaal(LesMateriaal lesMateriaal)
    {
        LesMateriaal.Remove(lesMateriaal);
    }
}
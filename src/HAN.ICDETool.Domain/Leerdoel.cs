namespace HAN.ICDETool.Domain;

public class Leerdoel
{
    public int Id { get; set; }
    public string Titel { get; init; }
    public string Omschrijving { get; init; }
    public IList<Rubric> GekoppeldeRubrics { get; } = new List<Rubric>();
    public IList<LesInrichting> GekoppeldeLessen { get; } = new List<LesInrichting>();
    public IList<SchriftelijkeToets> GekoppeldeToetsen { get; } = new List<SchriftelijkeToets>();

    public void KoppelRubrics(Rubric rubric)
    {
        GekoppeldeRubrics.Add(rubric);
    }

    public void OntkoppelRubric(Rubric rubric)
    {
        GekoppeldeRubrics.Remove(rubric);
    }

    public void KoppelLes(LesInrichting lesInrichting)
    {
        GekoppeldeLessen.Add(lesInrichting);
    }

    public void OntkoppelLes(LesInrichting lesInrichting)
    {
        GekoppeldeLessen.Remove(lesInrichting);
    }

    public void KoppelToets(SchriftelijkeToets schriftelijkeToets)
    {
        GekoppeldeToetsen.Add(schriftelijkeToets);
    }

    public void OntkoppelToets(SchriftelijkeToets schriftelijkeToets)
    {
        GekoppeldeToetsen.Remove(schriftelijkeToets);
    }
}
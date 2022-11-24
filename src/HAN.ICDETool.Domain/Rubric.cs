namespace HAN.ICDETool.Domain;

public class Rubric
{
    public int Id { get; set; }
    public string Titel { get; init; }
    public int Weging { get; init; }
    public int VoldoendeThreshold { get; set; }
    public int KnockoutThreshold { get; set; }
    public IList<BeoordelingsCriteria>? BeoordelingsCriteria { get; } = new List<BeoordelingsCriteria>();

    public void AddBeoordelingsCriteria(BeoordelingsCriteria beoordelingsCriteria)
    {
        BeoordelingsCriteria.Add(beoordelingsCriteria);
    }

    public void RemoveBeoordelingsCriteria(BeoordelingsCriteria beoordelingsCriteria)
    {
        BeoordelingsCriteria.Remove(beoordelingsCriteria);
    }
}
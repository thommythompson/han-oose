namespace HAN.ICDETool.Domain;

public class Leeruitkomst
{
    public int Id { get; set; }
    public string Titel { get; init; }
    public string Omschrijving { get; init; }
    public IList<Leerdoel> Leerdoelen { get; } = new List<Leerdoel>();

    public void KoppelLeerdoel(Leerdoel leerdoel)
    {
        Leerdoelen.Add(leerdoel);
    }
}
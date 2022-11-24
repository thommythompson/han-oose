namespace HAN.ICDETool.Domain;

public class EenheidVanLeeruitkomsten
{
    public int Id { get; set; }
    public String Titel { get; init; }
    public String Omschrijving { get; init; }
    public IList<Leeruitkomst> Leeruitkomsten { get; } = new List<Leeruitkomst>();

    public void AddLeeruitkomst(Leeruitkomst leeruitkomst)
    {
        Leeruitkomsten.Add(leeruitkomst);
    }
}
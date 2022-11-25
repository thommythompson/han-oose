using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization.Json;

namespace HAN.ICDETool.Domain;

public class EenheidVanLeeruitkomsten
{
    public int Id { get; set; }
    public String Titel { get; set; }
    public String Omschrijving { get; set; }
    public IEnumerable<Leeruitkomst> Leeruitkomsten { get => _leeruitkomsten; }
    private IList<Leeruitkomst> _leeruitkomsten { get; } = new List<Leeruitkomst>();

    public EenheidVanLeeruitkomsten(string titel, string omschrijving)
    {
        this.Titel = titel;
        this.Omschrijving = omschrijving;
    }

    public void AddLeeruitkomst(Leeruitkomst leeruitkomst)
    {
        _leeruitkomsten.Add(leeruitkomst);
    }
    
    public void RemoveLeeruitkomst(Leeruitkomst leeruitkomst)
    {
        _leeruitkomsten.Remove(leeruitkomst);
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class EenheidVanLeeruitkomsten
{
    public int Id { get; set; }
    public String Titel { get; init; }
    public String Omschrijving { get; init; }
    
    [NotMapped]
    public IEnumerable<Leeruitkomst> Leeruitkomsten { get => _leeruitkomsten; }
    private IList<Leeruitkomst> _leeruitkomsten { get; } = new List<Leeruitkomst>();

    public void AddLeeruitkomst(Leeruitkomst leeruitkomst)
    {
        _leeruitkomsten.Add(leeruitkomst);
    }
}
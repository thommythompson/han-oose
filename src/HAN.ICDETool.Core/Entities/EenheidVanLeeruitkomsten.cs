using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization.Json;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class EenheidVanLeeruitkomsten
{
    public int Id { get; set; }
    public String Titel { get; set; }
    public String Omschrijving { get; set; }
    [BackingField(nameof(_leeruitkomsten))]
    public IEnumerable<Leeruitkomst>? Leeruitkomsten { get => _leeruitkomsten; }
    private IList<Leeruitkomst>? _leeruitkomsten { get; } = new List<Leeruitkomst>();
    public int CourseInrichtingId { get; set; }

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
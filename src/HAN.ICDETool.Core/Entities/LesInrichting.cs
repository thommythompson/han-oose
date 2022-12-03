using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class LesInrichting : Validator
{
    public int Id { get; set; }
    public string Titel { get; set;  }
    [BackingField(nameof(_lesMateriaal))]
    public IEnumerable<LesMateriaal>? LesMateriaal { get => _lesMateriaal; }
    private IList<LesMateriaal>? _lesMateriaal { get; } = new List<LesMateriaal>();
    public int? CourseWeekInrichtingId { get; set; }
    public int CourseInrichtingId { get; set; }
    public Leerdoel Leerdoel { get; set; }
    public int LeerdoelId { get; set; }

    private LesInrichting(string titel)
    {
        this.Titel = titel;
    }
    public LesInrichting(string titel, Leerdoel leerdoel) : this(titel)
    {
        this.Leerdoel = leerdoel;
    }
    
    public void AddLesMateriaal(LesMateriaal lesMateriaal)
    {
        _lesMateriaal.Add(lesMateriaal);
    }

    public void RemoveLesMateriaal(LesMateriaal lesMateriaal)
    {
        _lesMateriaal.Remove(lesMateriaal);
    }

    public void validate()
    {
        throw new NotImplementedException();
    }
}
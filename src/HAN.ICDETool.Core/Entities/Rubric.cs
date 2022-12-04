using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class Rubric : Validator, BaseEntity
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public int Weging { get; set; } = 0;
    public int VoldoendeThreshold { get; set; } = 0;
    public int KnockoutThreshold { get; set; } = 0;
    [BackingField(nameof(_beoordelingsCriteria))]
    public IEnumerable<BeoordelingsCriteria>? BeoordelingsCriteria { get => _beoordelingsCriteria; } 
    private IList<BeoordelingsCriteria>? _beoordelingsCriteria { get; } = new List<BeoordelingsCriteria>();
    public Leerdoel Leerdoel { get; set; }
    public int LeerdoelId { get; set; }
    public int BeroepsProductId { get; set; }

    private Rubric(string titel)
    {
        this.Titel = titel;
    }
    
    public Rubric(string titel, Leerdoel leerdoel) : this(titel)
    {
        this.Leerdoel = leerdoel;
    }
    
    public void AddBeoordelingsCriteria(BeoordelingsCriteria beoordelingsCriteria)
    {
        _beoordelingsCriteria.Add(beoordelingsCriteria);
    }

    public void RemoveBeoordelingsCriteria(BeoordelingsCriteria beoordelingsCriteria)
    {
        _beoordelingsCriteria.Remove(beoordelingsCriteria);
    }

    public void validate()
    {
        throw new NotImplementedException();
    }
}
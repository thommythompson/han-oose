using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class Rubric
{
    public int Id { get; set; }
    public string Titel { get; }
    public int Weging { get; set; } = 0;
    public int VoldoendeThreshold { get; set; } = 0;
    public int KnockoutThreshold { get; set; } = 0;
    public IEnumerable<BeoordelingsCriteria> BeoordelingsCriteria { get => _beoordelingsCriteria; } 
    private IList<BeoordelingsCriteria> _beoordelingsCriteria { get; } = new List<BeoordelingsCriteria>();

    public Rubric(string titel)
    {
        this.Titel = titel;
    }
    
    public void AddBeoordelingsCriteria(BeoordelingsCriteria beoordelingsCriteria)
    {
        _beoordelingsCriteria.Add(beoordelingsCriteria);
    }

    public void RemoveBeoordelingsCriteria(BeoordelingsCriteria beoordelingsCriteria)
    {
        _beoordelingsCriteria.Remove(beoordelingsCriteria);
    }
}
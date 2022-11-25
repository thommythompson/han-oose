using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class Rubric
{
    public int Id { get; set; }
    public string Titel { get; init; }
    public int Weging { get; init; }
    public int VoldoendeThreshold { get; set; }
    public int KnockoutThreshold { get; set; }
   
    [NotMapped]
    public IEnumerable<BeoordelingsCriteria> BeoordelingsCriteria { get => _beoordelingsCriteria; } 
    private IList<BeoordelingsCriteria> _beoordelingsCriteria { get; } = new List<BeoordelingsCriteria>();

    public void AddBeoordelingsCriteria(BeoordelingsCriteria beoordelingsCriteria)
    {
        _beoordelingsCriteria.Add(beoordelingsCriteria);
    }

    public void RemoveBeoordelingsCriteria(BeoordelingsCriteria beoordelingsCriteria)
    {
        _beoordelingsCriteria.Remove(beoordelingsCriteria);
    }
}
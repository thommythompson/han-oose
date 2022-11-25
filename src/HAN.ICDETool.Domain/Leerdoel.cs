using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class Leerdoel
{
    public int Id { get; set; }
    public string Titel { get; init; }
    public string Omschrijving { get; init; }
    
    [NotMapped]
    public IEnumerable<Rubric> GekoppeldeRubrics { get => _gekoppeldeRubrics; }
    private IList<Rubric> _gekoppeldeRubrics { get; } = new List<Rubric>();
    
    [NotMapped]
    public IEnumerable<LesInrichting> GekoppeldeLessen { get => _gekoppeldeLessen; }
    private IList<LesInrichting> _gekoppeldeLessen { get; } = new List<LesInrichting>();
    
    [NotMapped]
    public IEnumerable<SchriftelijkeToets> GekoppeldeToetsen { get => _gekoppeldeToetsen; }
    private IList<SchriftelijkeToets> _gekoppeldeToetsen { get; } = new List<SchriftelijkeToets>();

    public void KoppelRubrics(Rubric rubric)
    {
        _gekoppeldeRubrics.Add(rubric);
    }

    public void OntkoppelRubric(Rubric rubric)
    {
        _gekoppeldeRubrics.Remove(rubric);
    }

    public void KoppelLes(LesInrichting lesInrichting)
    {
        _gekoppeldeLessen.Add(lesInrichting);
    }

    public void OntkoppelLes(LesInrichting lesInrichting)
    {
        _gekoppeldeLessen.Remove(lesInrichting);
    }

    public void KoppelToets(SchriftelijkeToets schriftelijkeToets)
    {
        _gekoppeldeToetsen.Add(schriftelijkeToets);
    }

    public void OntkoppelToets(SchriftelijkeToets schriftelijkeToets)
    {
        _gekoppeldeToetsen.Remove(schriftelijkeToets);
    }
}
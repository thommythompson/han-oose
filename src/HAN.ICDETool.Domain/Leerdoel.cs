using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace HAN.ICDETool.Domain;

public class Leerdoel
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public string Omschrijving { get; set; }
    public IEnumerable<Rubric> GekoppeldeRubrics { get => _gekoppeldeRubrics; }
    private IList<Rubric> _gekoppeldeRubrics { get; } = new List<Rubric>();
    public IEnumerable<LesInrichting> GekoppeldeLessen { get => _gekoppeldeLessen; }
    private IList<LesInrichting> _gekoppeldeLessen { get; } = new List<LesInrichting>();
    public IEnumerable<SchriftelijkeToets> GekoppeldeToetsen { get => _gekoppeldeToetsen; }
    private IList<SchriftelijkeToets> _gekoppeldeToetsen { get; } = new List<SchriftelijkeToets>();
    public int LeeruitkomstId { get; set; }
    
    public Leerdoel(string titel, string omschrijving)
    {
        this.Titel = titel;
        this.Omschrijving = omschrijving;
    }
    
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
    
    public void Validate()
    {
        IList<Validator> list = new List<Validator>();
        // list.AddRange(_gekoppeldeLessen);
        // list.AddRange(_gekoppeldeToetsen);
        // list.AddRange(_gekoppeldeRubrics);

        foreach (Validator lesEenheid in list)
        {
            lesEenheid.validate();
        }
    }
}


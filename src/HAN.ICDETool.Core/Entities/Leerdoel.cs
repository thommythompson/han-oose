using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class Leerdoel : BaseEntity
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public string Omschrijving { get; set; }
    [BackingField(nameof(_gekoppeldeRubrics))]
    public IEnumerable<Rubric>? GekoppeldeRubrics { get => _gekoppeldeRubrics; }
    private IList<Rubric>? _gekoppeldeRubrics { get; } = new List<Rubric>();
    [BackingField(nameof(_gekoppeldeLessen))]
    public IEnumerable<LesInrichting>? GekoppeldeLessen { get => _gekoppeldeLessen; }
    private IList<LesInrichting>? _gekoppeldeLessen { get; } = new List<LesInrichting>();
    [BackingField(nameof(_gekoppeldeToetsen))]
    public IEnumerable<SchriftelijkeToets>? GekoppeldeToetsen { get => _gekoppeldeToetsen; }
    private IList<SchriftelijkeToets>? _gekoppeldeToetsen { get; } = new List<SchriftelijkeToets>();
    public int LeeruitkomstId { get; set; }

    [NotMapped]
    private IEnumerable<Validator> _lesEenheden
    {
        get
        {
            List<Validator> list = new List<Validator>();
            list.AddRange(_gekoppeldeLessen);
            list.AddRange(_gekoppeldeToetsen);
            list.AddRange(_gekoppeldeRubrics);
            return list;
        }
    }

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
        foreach (Validator lesEenheid in _lesEenheden)
        {
            lesEenheid.validate();
        }
    }
}

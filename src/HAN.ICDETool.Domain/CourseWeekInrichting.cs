using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class CourseWeekInrichting
{
    public int Id { get; set; }
    
    public IEnumerable<SchriftelijkeToets> SchriftelijkeToets { get => _schriftelijkeToets; }
    private IList<SchriftelijkeToets> _schriftelijkeToets { get; } = new List<SchriftelijkeToets>();
    public IEnumerable<BeroepsProduct> BeroepsProduct { get => _beroepsProduct; }
    private IList<BeroepsProduct> _beroepsProduct { get; } = new List<BeroepsProduct>();
    public IEnumerable<LesInrichting> Lessen { get => _lessen; }
    private IList<LesInrichting> _lessen { get; } = new List<LesInrichting>();

    public void AddSchriftelijkeToets(SchriftelijkeToets schriftelijkeToets)
    {
        _schriftelijkeToets.Add(schriftelijkeToets);
    }
    
    public void RemoveSchriftelijkeToets(SchriftelijkeToets schriftelijkeToets)
    {
        _schriftelijkeToets.Remove(schriftelijkeToets);
    }

    public void AddBeroepsProduct(BeroepsProduct beroepsProduct)
    {
        _beroepsProduct.Add(beroepsProduct);
    }
    
    public void RemoveBeroepsProduct(BeroepsProduct beroepsProduct)
    {
        _beroepsProduct.Remove(beroepsProduct);
    }
    
    public void AddLes(LesInrichting les)
    {
        _lessen.Add(les);
    }
    
    public void RemoveLes(LesInrichting les)
    {
        _lessen.Remove(les);
    }
}
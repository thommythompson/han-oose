using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class CourseWeekInrichting
{
    public int Id { get; set; }
    
    [NotMapped]
    public IEnumerable<SchriftelijkeToets> SchriftelijkeToets { get => _schriftelijkeToets; }
    private IList<SchriftelijkeToets> _schriftelijkeToets { get; } = new List<SchriftelijkeToets>();
    
    [NotMapped]
    public IEnumerable<BeroepsProduct> BeroepsProduct { get => _beroepsProduct; }
    private IList<BeroepsProduct> _beroepsProduct { get; } = new List<BeroepsProduct>();
    
    [NotMapped]
    public IEnumerable<LesInrichting> Lessen { get => _lessen; }
    private IList<LesInrichting> _lessen { get; } = new List<LesInrichting>();

    public void AddSchriftelijkeToets(SchriftelijkeToets schriftelijkeToets)
    {
        _schriftelijkeToets.Add(schriftelijkeToets);
    }

    public void AddBeroepsProduct(BeroepsProduct beroepsProduct)
    {
        _beroepsProduct.Add(beroepsProduct);
    }
    
    public void AddLes(LesInrichting les)
    {
        _lessen.Add(les);
    }
}
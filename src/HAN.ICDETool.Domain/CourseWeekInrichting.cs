using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Domain;

public class CourseWeekInrichting
{
    public int Id { get; set; }

    [BackingField(nameof(_schriftelijkeToets))]
    public IEnumerable<SchriftelijkeToets>? SchriftelijkeToets { get => _schriftelijkeToets; }
    private IList<SchriftelijkeToets>? _schriftelijkeToets { get; } = new List<SchriftelijkeToets>();

    [BackingField(nameof(_schriftelijkeToets))]
    public IEnumerable<BeroepsProduct>? BeroepsProduct { get => _beroepsProduct; }
    private IList<BeroepsProduct>? _beroepsProduct { get; } = new List<BeroepsProduct>();
    [BackingField(nameof(_lessen))]
    public IEnumerable<LesInrichting>? Lessen { get => _lessen; }
    private IList<LesInrichting>? _lessen { get; } = new List<LesInrichting>();
    [BackingField(nameof(_courseWeekUitvoeringen))]
    public IEnumerable<CourseWeekUitvoering>? CourseWeekUitvoeringen { get => _courseWeekUitvoeringen; }
    private IList<CourseWeekUitvoering>? _courseWeekUitvoeringen { get; } = new List<CourseWeekUitvoering>();
    public int CourseWeekPlanningId { get; set; }

    public void AddToets(SchriftelijkeToets schriftelijkeToets)
    {
        _schriftelijkeToets.Add(schriftelijkeToets);
    }
    
    public void RemoveToets(SchriftelijkeToets schriftelijkeToets)
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
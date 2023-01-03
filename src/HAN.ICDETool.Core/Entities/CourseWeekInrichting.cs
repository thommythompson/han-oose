using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class CourseWeekInrichting : BaseEntity
{
    public int Id { get; set; }

    [BackingField(nameof(_schriftelijkeToets))]
    public IReadOnlyList<SchriftelijkeToets>? SchriftelijkeToets { get => _schriftelijkeToets; }
    private List<SchriftelijkeToets>? _schriftelijkeToets { get; } = new List<SchriftelijkeToets>();

    [BackingField(nameof(_schriftelijkeToets))]
    public IReadOnlyList<BeroepsProduct>? BeroepsProduct { get => _beroepsProduct; }
    private List<BeroepsProduct>? _beroepsProduct { get; } = new List<BeroepsProduct>();
    [BackingField(nameof(_lessen))]
    public IReadOnlyList<LesInrichting>? Lessen { get => _lessen; }
    private List<LesInrichting>? _lessen { get; } = new List<LesInrichting>();
    [BackingField(nameof(_courseWeekUitvoeringen))]
    public IReadOnlyList<CourseWeekUitvoering>? CourseWeekUitvoeringen { get => _courseWeekUitvoeringen; }
    private List<CourseWeekUitvoering>? _courseWeekUitvoeringen { get; } = new List<CourseWeekUitvoering>();
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
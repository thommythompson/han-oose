using System.ComponentModel.DataAnnotations.Schema;
using HAN.ICDETool.SharedKernel;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class CourseWeekUitvoering : BaseEntity
{
    public int Id { get; set; }
    public DateTimeOffset Maandag { get; }
    public CourseWeekInrichting CourseWeekInrichting { get; init; }
    public int CourseWeekInrichtingId { get; init; }
    [BackingField(nameof(_tentamen))]
    public IEnumerable<TentamenUitvoering>? Tentamen { get => _tentamen; }
    private IList<TentamenUitvoering>? _tentamen { get; } = new List<TentamenUitvoering>();
    [BackingField(nameof(_lessen))]
    public IEnumerable<LesUitvoering>? Lessen { get => _lessen; }
    private IList<LesUitvoering>? _lessen { get; } = new List<LesUitvoering>();
    public int CourseUitvoeringId { get; set; }

    // EF Core constructor: EF Core does not support navigation types in the constructor
    private CourseWeekUitvoering() { }

    public CourseWeekUitvoering(DateTimeOffset maandag, CourseWeekInrichting courseWeekInrichting) : this()
    {
        this.Maandag = maandag;
        this.CourseWeekInrichting = courseWeekInrichting;
        
        creeerTentamenUitvoeringen();
        creeerLesUitvoeringen();
    }
    
    private void creeerTentamenUitvoeringen()
    {
        foreach (SchriftelijkeToets schriftelijkeToets in CourseWeekInrichting.SchriftelijkeToets)
        {
            _tentamen.Add(new TentamenUitvoering(schriftelijkeToets));
        }

        foreach (BeroepsProduct beroepsProduct in CourseWeekInrichting.BeroepsProduct)
        {
            _tentamen.Add(new TentamenUitvoering(beroepsProduct));
        }
    }

    private void creeerLesUitvoeringen()
    {
        foreach (LesInrichting les in CourseWeekInrichting.Lessen)
        {
            _lessen.Add(new LesUitvoering(les));
        }
    }
}
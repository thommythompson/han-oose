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
    public IReadOnlyList<TentamenUitvoering>? Tentamen { get => _tentamen; }
    private List<TentamenUitvoering>? _tentamen { get; } = new List<TentamenUitvoering>();
    [BackingField(nameof(_lessen))]
    public IReadOnlyList<LesUitvoering>? Lessen { get => _lessen; }
    private List<LesUitvoering>? _lessen { get; } = new List<LesUitvoering>();
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
            var tentamenUitvoering = new TentamenUitvoering(schriftelijkeToets);
            
            _tentamen.Add(tentamenUitvoering);
        }

        foreach (BeroepsProduct beroepsProduct in CourseWeekInrichting.BeroepsProduct)
        {
            var tentamenUitvoering = new TentamenUitvoering(beroepsProduct);
            
            _tentamen.Add(tentamenUitvoering);
        }
    }

    private void creeerLesUitvoeringen()
    {
        foreach (LesInrichting les in CourseWeekInrichting.Lessen)
        {
            var lesUitvoering = new LesUitvoering(les);
            _lessen.Add(lesUitvoering);
        }
    }
}
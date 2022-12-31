using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class CourseWeekPlanning : BaseEntity
{
    public int Id { get; set; }
    public ITijdDefinitie Duur { get; }

    [BackingField(nameof(_weken))]
    public IReadOnlyList<CourseWeekInrichting> Weken { get => _weken; }
    private List<CourseWeekInrichting> _weken { get; } = new List<CourseWeekInrichting>();
    public int CourseInrichtingId { get; set; }

    // EF Core constructor: EF Core does not support navigation types in the constructor
    private CourseWeekPlanning() { }

    public CourseWeekPlanning(ITijdDefinitie duur) : this()
    {
        this.Duur = duur;
        vulPlanningMetWeken();
    }
    
    private void vulPlanningMetWeken()
    {
        for (int i = 0; i < Duur.DuurInWeken; i++)
        {
            _weken.Add(new CourseWeekInrichting());
        }
    }
}
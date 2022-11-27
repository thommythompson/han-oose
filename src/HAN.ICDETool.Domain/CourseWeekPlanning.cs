using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Domain;

public class CourseWeekPlanning
{
    public int Id { get; set; }
    public ITijdDefinitie Duur { get; }

    [BackingField(nameof(_weken))]
    public IEnumerable<CourseWeekInrichting> Weken { get => _weken; }
    private IList<CourseWeekInrichting> _weken { get; } = new List<CourseWeekInrichting>();
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
using System.ComponentModel.DataAnnotations.Schema;
using HAN.ICDETool.SharedKernel;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class CourseUitvoering : BaseEntity
{
    public int Id { get; set; }
    public CourseInrichting CourseInrichting { get; init; }
    public int CourseInrichtingId { get; init; }
    public DateTimeOffset StartDatum { get; init; }
    [BackingField(nameof(_weken))]
    public IReadOnlyList<CourseWeekUitvoering>? Weken{ get => _weken; }
    private List<CourseWeekUitvoering>? _weken { get; set; } = new();
    [BackingField(nameof(_studenten))]
    public IReadOnlyList<Persoon>? Studenten{ get => _studenten; }
    private List<Persoon>? _studenten { get; set; } = new();
    

    // EF Core constructor: EF Core does not support navigation types in the constructor
    private CourseUitvoering() { }

    public CourseUitvoering(CourseInrichting courseInrichting, DateTimeOffset startDatum) : this()
    {
        this.CourseInrichting = courseInrichting;
        this.StartDatum = startDatum.GetMondayOfThisWeek();
        creeerWeekUitvoeringen();
    }
    
    private void creeerWeekUitvoeringen()
    {
        int i = 0;
        foreach (CourseWeekInrichting week in CourseInrichting.Planning.Weken)
        {
            DateTimeOffset date = StartDatum.AddDays(7 * i);

            var weekUitvoering = new CourseWeekUitvoering(date, week);
            
            _weken.Add(weekUitvoering);
            
            i++;
        }
    }
}
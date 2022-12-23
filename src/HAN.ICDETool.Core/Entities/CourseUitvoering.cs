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
    public IList<CourseWeekUitvoering> Weken { get;  } = new List<CourseWeekUitvoering>();
    public IList<Persoon> Studenten { get; set; } = new List<Persoon>();

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
            
            Weken.Add(new CourseWeekUitvoering(date, week));
            
            i++;
        }
    }
}
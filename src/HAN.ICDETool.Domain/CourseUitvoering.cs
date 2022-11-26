using System.ComponentModel.DataAnnotations.Schema;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Domain;

public class CourseUitvoering
{
    public int Id { get; set; }
    public CourseInrichting CourseInrichting { get; init; }
    public DateTimeOffset StartDatum { get; init; }
    public IEnumerable<CourseWeekUitvoering> Weken { get => _weken;}
    private IList<CourseWeekUitvoering> _weken { get; } = new List<CourseWeekUitvoering>();

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
            
            _weken.Add(new CourseWeekUitvoering(date, week));
            
            i++;
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Domain;

public class CourseUitvoering
{
    public int Id { get; set; }
    public CourseInrichting CourseInrichting { get; }
    public DateTimeOffset StartDatum { get;  }
    public IEnumerable<CourseWeekUitvoering> Weken { get => _weken;}
    private IList<CourseWeekUitvoering> _weken { get; } = new List<CourseWeekUitvoering>();
    
    public CourseUitvoering(CourseInrichting courseInrichting, DateTimeOffset startDatum)
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
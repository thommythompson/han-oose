using System.ComponentModel.DataAnnotations.Schema;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Domain;

public class CourseUitvoering
{
    public int Id { get; set; }
    public CourseInrichting CourseInrichting { get; init; }
    public IList<CourseWeekUitvoering> Weken { get; } = new List<CourseWeekUitvoering>();
    private DateTimeOffset _startDatum { get; set; }
    [NotMapped]
    public DateTimeOffset StartDatum
    {
        get
        {
            return this._startDatum;
        }
        init
        {
            _startDatum = value.GetMondayOfThisWeek();
            creeerWeekUitvoeringen();
        }
    }
    
    private void creeerWeekUitvoeringen()
    {
        int i = 0;
        foreach (CourseWeekInrichting week in CourseInrichting.Planning.Weken)
        {
            DateTimeOffset date = _startDatum.AddDays(7 * i);
            
            Weken.Add(new CourseWeekUitvoering
            {
                Monday = date,
                CourseWeekInrichting = week
            });
            
            i++;
        }
    }
}
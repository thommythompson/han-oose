using System.ComponentModel.DataAnnotations.Schema;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Domain;

public class CourseUitvoering
{
    public int Id { get; set; }
    public CourseInrichting CourseInrichting { get; init; }
    
    [NotMapped]
    public IEnumerable<CourseWeekUitvoering> Weken { get => _weken;}
    private IList<CourseWeekUitvoering> _weken { get; } = new List<CourseWeekUitvoering>();
    
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
    private DateTimeOffset _startDatum { get; set; }
    
    private void creeerWeekUitvoeringen()
    {
        int i = 0;
        foreach (CourseWeekInrichting week in CourseInrichting.Planning.Weken)
        {
            DateTimeOffset date = _startDatum.AddDays(7 * i);
            
            _weken.Add(new CourseWeekUitvoering
            {
                Monday = date,
                CourseWeekInrichting = week
            });
            
            i++;
        }
    }
}
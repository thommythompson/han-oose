using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class CourseWeekPlanning
{
    public int Id { get; set; }
    public ITijdDefinitie Duur { get; }

    public IEnumerable<CourseWeekInrichting> Weken { get => _weken; }
    private IList<CourseWeekInrichting> _weken { get; } = new List<CourseWeekInrichting>();

    public CourseWeekPlanning(ITijdDefinitie duur)
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
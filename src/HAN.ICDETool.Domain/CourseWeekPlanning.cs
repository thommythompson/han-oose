using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class CourseWeekPlanning
{
    public int Id { get; set; }
    
    [NotMapped]
    public ITijdDefinitie Duur
    {
        get
        {
            return this._duur;
        }
        init
        {
            this._duur = value;
            vulPlanningMetWeken();   
        }
    }
    private ITijdDefinitie _duur { get; set; }
    
    [NotMapped]
    public IEnumerable<CourseWeekInrichting> Weken { get => _weken; }
    private IList<CourseWeekInrichting> _weken { get; } = new List<CourseWeekInrichting>();

    private void vulPlanningMetWeken()
    {
        for (int i = 0; i < _duur.DuurInWeken; i++)
        {
            _weken.Add(new CourseWeekInrichting());
        }
    }
}
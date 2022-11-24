using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class CourseWeekPlanning
{
    public int Id { get; set; }
    private ITijdDefinitie _duur { get; set; }
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

    public IList<CourseWeekInrichting> Weken { get; } = new List<CourseWeekInrichting>();

    private void vulPlanningMetWeken()
    {
        for (int i = 0; i < _duur.DuurInWeken; i++)
        {
            Weken.Add(new CourseWeekInrichting());
        }
    }
}
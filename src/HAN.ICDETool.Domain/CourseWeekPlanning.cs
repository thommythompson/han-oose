namespace HAN.ICDETool.Domain;

public class CourseWeekPlanning
{
    public IList<CourseWeekInrichting> Weken { get; private set;  }

    public CourseWeekPlanning(ITijdDefinitie duur)
    {
        Weken = new List<CourseWeekInrichting>();
        vulPlanningMetWeken(duur);
    }

    private void vulPlanningMetWeken(ITijdDefinitie duur)
    {
        for (int i = 0; i < duur.DuurInWeken; i++)
        {
            Weken.Add(new CourseWeekInrichting());
        }
    }
}
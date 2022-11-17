namespace HAN.ICDETool.Domain;

public class CourseWeekPlanning
{
    public IList<CourseWeekInrichting> weken { get; private set;  }

    public CourseWeekPlanning(ITijdDefinitie duur)
    {
        weken = new List<CourseWeekInrichting>();
        vulPlanningMetWeken(duur);
    }

    private void vulPlanningMetWeken(ITijdDefinitie duur)
    {
        for (int i = 0; i < duur.duurInWeken; i++)
        {
            weken.Add(new CourseWeekInrichting());
        }
    }
}
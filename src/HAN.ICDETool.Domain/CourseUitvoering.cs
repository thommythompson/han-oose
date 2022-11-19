namespace HAN.ICDETool.Domain;

public class CourseUitvoering
{
    public CourseInrichting? CourseInrichting { get; private set; }
    public IList<CourseWeekUitvoering>? Weken { get; private set; } = new List<CourseWeekUitvoering>();

    public CourseUitvoering(CourseInrichting courseInrichting, DateOnly date)
    {
        CourseInrichting = courseInrichting;
        creeerWeekUitvoeringen(date);
    }

    private void creeerWeekUitvoeringen(DateOnly date)
    {
        int i = 0;
        foreach (CourseWeekInrichting week in CourseInrichting.Planning.Weken)
        {
            date = date.AddDays(7 * i);
            
            Weken.Add(new CourseWeekUitvoering(week, date));
            
            i++;
        }
    }
}
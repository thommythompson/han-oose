namespace HAN.ICDETool.Domain;

public class CourseUitvoering
{
    private CourseInrichting _courseInrichting { get; set; }
    private IList<CourseWeekUitvoering> _weken { get; set; }
}
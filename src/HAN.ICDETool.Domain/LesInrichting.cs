namespace HAN.ICDETool.Domain;

public class LesInrichting
{
    private CourseWeekInrichting? _courseWeek { get; set; }
    private IList<LesMateriaal>? _lesMateriaal { get; set; }
    private IList<Leerdoel>? _leerdoelen { get; set; }
}
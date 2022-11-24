namespace HAN.ICDETool.Domain;

public class CourseBibliotheek
{
    public IList<CourseInrichting> Courses { get; private set; } = new List<CourseInrichting>();
    
    public void AddCourse(CourseInrichting courseInrichting)
    {
        Courses.Add(courseInrichting);
    }
}
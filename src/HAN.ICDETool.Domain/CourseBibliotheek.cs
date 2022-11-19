namespace HAN.ICDETool.Domain;

public class CourseBibliotheek
{
    public IList<CourseInrichting>? Courses { get; private set; }

    public CourseBibliotheek()
    {
        Courses = new List<CourseInrichting>();
    }
    public void CreerCourse(String titel)
    {
        Courses.Add(
            new CourseInrichting(titel)
            );
    }
}
namespace HAN.ICDETool.Domain;

public class CourseBibliotheek
{
    public IList<CourseInrichting>? courses { get; private set; }

    public CourseBibliotheek()
    {
        courses = new List<CourseInrichting>();
    }
    public void CreerCourse(String titel)
    {
        courses.Add(
            new CourseInrichting(titel)
            );
    }
}
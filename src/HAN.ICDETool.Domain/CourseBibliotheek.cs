using HAN.ICDETool.Domain.Constanten;

namespace HAN.ICDETool.Domain;

public class CourseBibliotheek
{
    private static CourseBibliotheek _instance;
    private IList<CourseInrichting> _courses = new List<CourseInrichting>();

    private CourseBibliotheek()
    {
    }

    public static CourseBibliotheek CreateInstance()
    {
        if (_instance == null)
            _instance = new CourseBibliotheek();

        return _instance;
    }

    public void AddCourse(String titel, TijdsEenheid duur)
    {
        CourseInrichting newCourse = new CourseInrichting(titel, duur);
        _courses.Add(newCourse);
    }

    public IList<CourseInrichting> GetCourses()
    {
        return _courses;
    }
}
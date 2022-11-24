namespace HAN.ICDETool.Tests;

public class TestCourseBibiliotheek
{
    private CourseBibliotheek _courseBibliotheek;
    
    [SetUp]
    public void Setup()
    {
        _courseBibliotheek = new CourseBibliotheek();
    }

    [Test]
    public void TestCourseCreation()
    {
        CourseInrichting courseInrichting = new CourseInrichting
        {
            Titel = "Titel"
        };
        _courseBibliotheek.AddCourse(courseInrichting);
        
        Assert.That(_courseBibliotheek.Courses[0].Titel, Is.EqualTo("Titel"));
    }
}
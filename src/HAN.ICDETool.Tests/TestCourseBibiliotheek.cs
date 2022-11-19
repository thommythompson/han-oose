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
        _courseBibliotheek.CreerCourse("naam", new Semester());
        
        Assert.That(_courseBibliotheek.Courses[0].Titel, Is.EqualTo("naam"));
    }
}
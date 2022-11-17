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
        _courseBibliotheek.CreerCourse("naam");
        
        Assert.That(_courseBibliotheek.courses[0].titel, Is.EqualTo("naam"));
    }
}
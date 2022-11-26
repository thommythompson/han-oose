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
        Docent docent = new Docent("Voornaam", "Achternaam", "v.achternaam@email.com");
        
        CourseInrichting courseInrichting = new CourseInrichting("Titel", "Omschrijving", docent);
        
        _courseBibliotheek.AddCourse(courseInrichting);
        
        Assert.That(_courseBibliotheek.Courses.First().Titel, Is.EqualTo("Titel"));
    }
}
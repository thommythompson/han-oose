namespace HAN.ICDETool.Tests;

public class TestCourseBibiliotheek
{
    private CourseBibliotheek? _courseBibliotheek;
    
    [SetUp]
    public void Setup()
    {
        _courseBibliotheek = CourseBibliotheek.CreateInstance();
    }

    [Test]
    public void TestCourseCreation()
    {
        _courseBibliotheek.AddCourse("test", OnderwijsTijdsEenheden.Jaar);

        IList<CourseInrichting> courses = _courseBibliotheek.GetCourses();
        
        Assert.That(courses[0].GetTitel(), Is.EqualTo("test"));
    }
}
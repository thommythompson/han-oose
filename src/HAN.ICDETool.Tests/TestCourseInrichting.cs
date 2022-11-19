using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Tests;

public class TestCourseInrichting
{
    private CourseInrichting _courseInrichting;
    
    [SetUp]
    public void Setup()
    {
        _courseInrichting = new CourseInrichting("Test Course Inrichting", new Semester());

        CourseWeekInrichting week = _courseInrichting.Planning.Weken[0];
        
        _courseInrichting.VoegLesToe("les 1", week);
        _courseInrichting.VoegTentamenToe("tentamen 1", week);
    }

    [Test]
    public void TestStartCourseUitvoeringVanInrichtingDieNietDefintiefIs()
    {
        DateOnly date = DateTime.Now.ToDateOnly();

        Assert.Throws<Exception>(() => _courseInrichting.StartCourseUitvoering(date));
    }
    
    [Test]
    public void TestStartCourseUitvoering()
    {
        DateOnly date = DateTime.Now.ToDateOnly();

        _courseInrichting.maakDefintief();

        CourseUitvoering _courseUitvoering = _courseInrichting.StartCourseUitvoering(date);
        
        Assert.That(_courseUitvoering.CourseInrichting, Is.EqualTo(_courseInrichting));
    }
}
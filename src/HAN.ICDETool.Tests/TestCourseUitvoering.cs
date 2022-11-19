using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Tests;

public class TestCourseUitvoering
{
    private CourseUitvoering _courseUitvoering;
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
    public void TestMaandagDatumToewijzing()
    {
        DateOnly date = new DateOnly(2022, 11, 19);

        _courseInrichting.maakDefintief();

        CourseUitvoering _courseUitvoering = _courseInrichting.StartCourseUitvoering(date);
        
        Assert.That(_courseUitvoering.Weken[0].Monday, Is.EqualTo(new DateOnly(2022, 11, 14)));
    }
}
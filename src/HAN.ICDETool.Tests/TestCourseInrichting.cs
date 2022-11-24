using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Tests;

public class TestCourseInrichting
{
    private CourseInrichting _courseInrichting;
    
    [SetUp]
    public void Setup()
    {
        _courseInrichting = new CourseInrichting
        {
            Titel = "Titel",
            Duur = new Semester()
        };
        
        _courseInrichting.AddLes(new LesInrichting
        {
            Titel = "Les1"
        });
        
        _courseInrichting.AddTentamen(new SchriftelijkeToets
        {
            Titel = "Toets1"
        });
    }

    [Test]
    public void TestStartCourseUitvoeringVanInrichtingDieNietDefintiefIs()
    {
        DateTimeOffset date = DateTime.Now;

        Assert.Throws<Exception>(() => _courseInrichting.StartCourseUitvoering(date));
    }
    
    [Test]
    public void TestStartCourseUitvoering()
    {
        DateTimeOffset date = DateTime.Now;

        _courseInrichting.MaakDefintief();

        CourseUitvoering _courseUitvoering = _courseInrichting.StartCourseUitvoering(date);
        
        Assert.That(_courseUitvoering.CourseInrichting, Is.EqualTo(_courseInrichting));
    }
}
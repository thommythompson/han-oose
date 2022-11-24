using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Tests;

public class TestWeekplanning
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
    }

    [Test]
    public void TestAantalPlanningWekenSemester()
    {
        CourseWeekPlanning courseWeekPlanning = new CourseWeekPlanning
        {
            Duur = new Semester()
        };
        
        Assert.That(courseWeekPlanning.Weken.Count, Is.EqualTo(new Semester().DuurInWeken));
    }
    
    [Test]
    public void TestAantalPlanningWekenPeriode()
    {
        CourseWeekPlanning courseWeekPlanning = new CourseWeekPlanning
        {
            Duur = new Periode()
        };

        Assert.That(courseWeekPlanning.Weken.Count, Is.EqualTo(new Periode().DuurInWeken));
    }
}
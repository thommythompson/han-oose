using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Tests;

public class TestWeekplanning
{
    private CourseInrichting _courseInrichting;
    
    [SetUp]
    public void Setup()
    {
        Docent docent = new Docent("Voornaam", "Achternaam", "v.achternaam@email.com");
        
        CourseInrichting courseInrichting = new CourseInrichting("Titel", "Omschrijving", docent);
        
        courseInrichting.CreatePlanning(new Semester());
        
    }

    [Test]
    public void TestAantalPlanningWekenSemester()
    {
        _courseInrichting.CreatePlanning(new Semester());
        
        Assert.That(_courseInrichting.Planning.Weken.Count, Is.EqualTo(new Semester().DuurInWeken));
    }
    
    [Test]
    public void TestAantalPlanningWekenPeriode()
    {
        _courseInrichting.CreatePlanning(new Periode());

        Assert.That(_courseInrichting.Planning.Weken.Count, Is.EqualTo(new Periode().DuurInWeken));
    }
}
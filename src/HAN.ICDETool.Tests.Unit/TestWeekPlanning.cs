using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Tests.Unit;

public class TestWeekplanning
{
    private Persoon _docent;
    
    [SetUp]
    public void Setup()
    {
        _docent = new Persoon("Voornaam", "Achternaam", "v.achternaam@email.com");
    }

    [Test]
    public void TestAantalPlanningWekenSemester()
    {
        var courseInrichting = new CourseInrichting("Titel", "Omschrijving", _docent);
        
        courseInrichting.CreatePlanning(new Semester());
        
        Assert.That(courseInrichting.Planning.Weken.Count, Is.EqualTo(new Semester().DuurInWeken));
    }
    
    [Test]
    public void TestAantalPlanningWekenPeriode()
    {
        var courseInrichting = new CourseInrichting("Titel", "Omschrijving", _docent);
        
        courseInrichting.CreatePlanning(new Periode());

        Assert.That(courseInrichting.Planning.Weken.Count, Is.EqualTo(new Periode().DuurInWeken));
    }
}
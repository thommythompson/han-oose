using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;
using Microsoft.AspNetCore.Identity;

namespace HAN.ICDETool.Tests;

public class TestCourseInrichting
{
    private CourseInrichting _courseInrichting;
    
    [SetUp]
    public void Setup()
    {
        Persoon docent = new Persoon("Voornaam", "Achternaam", "v.achternaam@email.com");
        
        CourseInrichting courseInrichting = new CourseInrichting("Titel", "Omschrijving", docent);
        
        courseInrichting.CreatePlanning(new Semester());

        Leerdoel leerdoel = new Leerdoel("titel", "omschrijving");
        
        _courseInrichting.AddLes(new LesInrichting("Titel", leerdoel));
        
        _courseInrichting.AddToets(new SchriftelijkeToets("Titel", leerdoel));
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
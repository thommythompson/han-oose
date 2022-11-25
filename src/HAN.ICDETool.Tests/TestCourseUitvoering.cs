using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Tests;

public class TestCourseUitvoering
{
    private CourseInrichting _courseInrichting;
    
    [SetUp]
    public void Setup()
    {
        Docent docent = new Docent("Voornaam", "Achternaam", "v.achternaam@email.com");
        
        CourseInrichting courseInrichting = new CourseInrichting("Titel", "Omschrijving", docent);
        
        courseInrichting.CreatePlanning(new Semester());

        _courseInrichting.AddLes(new LesInrichting("Titel"));
        
        _courseInrichting.AddTentamen(new SchriftelijkeToets("Titel"));
    }

    [Test]
    public void TestMaandagDatumToewijzing()
    {
        DateTimeOffset date = new DateTime(2022, 11, 19);

        _courseInrichting.MaakDefintief();

        CourseUitvoering _courseUitvoering = _courseInrichting.StartCourseUitvoering(date);
        
        Assert.That(_courseUitvoering.Weken.First().Maandag, Is.EqualTo((DateTimeOffset)new DateTime(2022, 11, 14)));
    }
}
using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Tests;

public class TestCourseUitvoering
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
    public void TestMaandagDatumToewijzing()
    {
        DateTimeOffset date = new DateTime(2022, 11, 19);

        _courseInrichting.MaakDefintief();

        CourseUitvoering _courseUitvoering = _courseInrichting.StartCourseUitvoering(date);
        
        Assert.That(_courseUitvoering.Weken.First().Maandag, Is.EqualTo((DateTimeOffset)new DateTime(2022, 11, 14)));
    }
}
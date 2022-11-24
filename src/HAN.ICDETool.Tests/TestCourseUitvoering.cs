using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Tests;

public class TestCourseUitvoering
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
    public void TestMaandagDatumToewijzing()
    {
        DateTimeOffset date = new DateTime(2022, 11, 19);

        _courseInrichting.MaakDefintief();

        CourseUitvoering _courseUitvoering = _courseInrichting.StartCourseUitvoering(date);
        
        Assert.That(_courseUitvoering.Weken[0].Monday, Is.EqualTo((DateTimeOffset)new DateTime(2022, 11, 14)));
    }
}
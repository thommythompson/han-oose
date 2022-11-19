using System.Diagnostics.SymbolStore;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Tests;

public class TestWeekplanning
{
    private CourseUitvoering _courseUitvoering;
    
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void TestAantalPlanningWekenSemester()
    {
        ITijdDefinitie semester = new Semester();
        
        CourseWeekPlanning _planning = new CourseWeekPlanning(semester);
        
        Assert.That(_planning.Weken.Count, Is.EqualTo(semester.DuurInWeken));
    }
    
    [Test]
    public void TestAantalPlanningWekenPeriode()
    {
        ITijdDefinitie periode = new Periode();
        
        CourseWeekPlanning _planning = new CourseWeekPlanning(periode);
        
        Assert.That(_planning.Weken.Count, Is.EqualTo(periode.DuurInWeken));
    }
}
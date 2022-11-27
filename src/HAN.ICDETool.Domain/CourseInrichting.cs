using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Domain;

public class CourseInrichting
{
    public int Id { get; set; }
    public String Titel { get; set; }
    public String Omschrijving { get; set; }
    public Docent AangemaaktDoor { get; }
    public CourseWeekPlanning Planning { get; private set; }
    public bool IsDefintief { get; private set; } = false;
    public DateTimeOffset AanmaakDatum { get;  } = DateTimeOffset.Now;
    [BackingField(nameof(_evls))]
    public IEnumerable<EenheidVanLeeruitkomsten> Evls { get => _evls; }
    private IList<EenheidVanLeeruitkomsten> _evls { get; } = new List<EenheidVanLeeruitkomsten>();
    [BackingField(nameof(_tentamen))]
    public IEnumerable<TentamenInrichting> Tentamen { get => _tentamen; }
    private IList<TentamenInrichting> _tentamen { get; } = new List<TentamenInrichting>();
    [BackingField(nameof(_lessen))]
    public IEnumerable<LesInrichting> Lessen { get => _lessen; } 
    private IList<LesInrichting> _lessen { get; } = new List<LesInrichting>();
    [BackingField(nameof(_courseUitvoeringen))]
    public IEnumerable<CourseUitvoering> CourseUitvoeringen { get => _courseUitvoeringen; } 
    private IList<CourseUitvoering> _courseUitvoeringen { get; } = new List<CourseUitvoering>();
    public int CourseBibliotheekId { get; set; }


    // EF Core constructor: EF Core does not support navigation types in the constructor
    private CourseInrichting(string titel, string omschrijving)
    {
        this.Titel = titel;
        this.Omschrijving = omschrijving;
    }

    public CourseInrichting(string titel, string omschrijving, Docent aangemaaktDoor) : this(titel, omschrijving)
    {
        this.AangemaaktDoor = aangemaaktDoor;
    }
    
    public void MaakDefintief()
    {
        IsDefintief = true;
    }

    public void AddEenheidVanLeeruitkomsten(EenheidVanLeeruitkomsten eenheidVanLeeruitkomsten)
    {
        _evls.Add(eenheidVanLeeruitkomsten);
    }
    
    public void RemoveEenheidVanLeeruitkomsten(EenheidVanLeeruitkomsten eenheidVanLeeruitkomsten)
    {
        _evls.Remove(eenheidVanLeeruitkomsten);
    }
    
    public void AddTentamen(TentamenInrichting tentamenInrichting)
    {
        _tentamen.Add(tentamenInrichting);
    }
    
    public void RemoveTentamen(TentamenInrichting tentamenInrichting)
    {
        _tentamen.Remove(tentamenInrichting);
    }

    public void AddLes(LesInrichting lesInrichting)
    {
        _lessen.Add(lesInrichting);
    }
    
    public void RemoveLes(LesInrichting lesInrichting)
    {
        _lessen.Remove(lesInrichting);
    }

    public void CreatePlanning(ITijdDefinitie duur)
    {
        if (null != Planning)
            throw new Exception("Planning is already created, remove the current one first");

        this.Planning = new CourseWeekPlanning(duur);
    }

    public void RemovePlanning()
    {
        this.Planning = null;
    }

    public CourseUitvoering StartCourseUitvoering(DateTimeOffset date)
    {
        if (!IsDefintief)
            throw new Exception("Kan geen uitvoering starten van een course inrichting die niet defintief is.");

        return new CourseUitvoering(this, date);
    }
}
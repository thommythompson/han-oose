using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class CourseInrichting : BaseEntity
{
    public int Id { get; set; }
    public String Titel { get; set; }
    public String Omschrijving { get; set; }
    public Persoon AangemaaktDoor { get; }
    public CourseWeekPlanning? Planning { get; private set; }
    public bool IsDefintief { get; private set; } = false;
    public DateTimeOffset AanmaakDatum { get;  } = DateTimeOffset.Now;
    [BackingField(nameof(_evls))]
    public IReadOnlyList<EenheidVanLeeruitkomsten>? Evls { get => _evls; }
    private List<EenheidVanLeeruitkomsten>? _evls { get; } = new List<EenheidVanLeeruitkomsten>();
    [BackingField(nameof(_beroepsProducten))]
    public IReadOnlyList<BeroepsProduct>? BeroepsProducten { get => _beroepsProducten; }
    private List<BeroepsProduct>? _beroepsProducten { get; } = new List<BeroepsProduct>();
    [BackingField(nameof(_toetsen))]
    public IReadOnlyList<SchriftelijkeToets>? Toetsen { get => _toetsen; }
    private List<SchriftelijkeToets>? _toetsen { get; } = new List<SchriftelijkeToets>();
    [BackingField(nameof(_lessen))]
    public IReadOnlyList<LesInrichting>? Lessen { get => _lessen; } 
    private List<LesInrichting>? _lessen { get; } = new List<LesInrichting>();
    [BackingField(nameof(_courseUitvoeringen))]
    public IReadOnlyList<CourseUitvoering>? CourseUitvoeringen { get => _courseUitvoeringen; } 
    private List<CourseUitvoering>? _courseUitvoeringen { get; } = new List<CourseUitvoering>();


    // EF Core constructor: EF Core does not support navigation types in the constructor
    private CourseInrichting(string titel, string omschrijving)
    {
        this.Titel = titel;
        this.Omschrijving = omschrijving;
    }

    public CourseInrichting(string titel, string omschrijving, Persoon aangemaaktDoor) : this(titel, omschrijving)
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
    
    public void AddBeroepsProduct(BeroepsProduct beroepsProduct)
    {
        _beroepsProducten.Add(beroepsProduct);
    }
    
    public void RemoveBeroepsProduct(BeroepsProduct beroepsProduct)
    {
        _beroepsProducten.Remove(beroepsProduct);
    }

    public void AddToets(SchriftelijkeToets toets)
    {
        _toetsen.Add(toets);
    }

    public void RemoveToets(SchriftelijkeToets toets)
    {
        _toetsen.Remove(toets);
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
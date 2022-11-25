using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace HAN.ICDETool.Domain;

public class CourseInrichting
{
    public int Id { get; set; }
    public String Titel { get; init; }
    public String Omschrijving { get; init; }
    public Docent AangemaaktDoor { get; init; }
    public CourseWeekPlanning Planning { get; private set; }
    public bool IsDefintief { get; private set; } = false;
    
    [NotMapped]
    public ITijdDefinitie Duur
    {
        get
        {
            return this.Planning.Duur;
        }
        init
        {
            this.Planning = new CourseWeekPlanning
            {
                Duur = value
            };
        }
    }

    [NotMapped]
    public DateTimeOffset AanmaakDatum
    {
        get => this._aanmaakDatum;
        init => this._aanmaakDatum = DateTimeOffset.Now;
    }
    private DateTimeOffset _aanmaakDatum { get; set; }
    
    [NotMapped]
    public IEnumerable<EenheidVanLeeruitkomsten> Evls { get => _evls; }
    private IList<EenheidVanLeeruitkomsten> _evls { get; } = new List<EenheidVanLeeruitkomsten>();
    
    [NotMapped]
    public IEnumerable<TentamenInrichting> Tentamen { get => _tentamen; }
    private IList<TentamenInrichting> _tentamen { get; } = new List<TentamenInrichting>();
    
    [NotMapped]
    public IEnumerable<LesInrichting> Lessen { get => _lessen; } 
    private IList<LesInrichting> _lessen { get; } = new List<LesInrichting>();
    
    public void MaakDefintief()
    {
        IsDefintief = true;
    }

    public void AddEenheidVanLeeruitkomsten(EenheidVanLeeruitkomsten eenheidVanLeeruitkomsten)
    {
        _evls.Add(eenheidVanLeeruitkomsten);
    }
    
    public void AddTentamen(TentamenInrichting tentamenInrichting)
    {
        _tentamen.Add(tentamenInrichting);
    }

    public void AddLes(LesInrichting lesInrichting)
    {
        _lessen.Add(lesInrichting);
    }

    public CourseUitvoering StartCourseUitvoering(DateTimeOffset date)
    {
        if (!IsDefintief)
            throw new Exception("Kan geen uitvoering starten van een course inrichting die niet defintief is.");

        return new CourseUitvoering
        {
            CourseInrichting = this,
            StartDatum = date
        };
    }
}
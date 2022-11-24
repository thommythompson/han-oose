using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace HAN.ICDETool.Domain;

public class CourseInrichting
{
    public int Id { get; set; }
    public String Titel { get; init; }
    public String Omschrijving { get; init; }
    public Docent AangemaaktDoor { get; init; }
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
    private DateTimeOffset _aanmaakDatum { get; set; }
    [NotMapped]
    public DateTimeOffset AanmaakDatum
    {
        get => this._aanmaakDatum;
        init => this._aanmaakDatum = DateTimeOffset.Now;
    }
    public CourseWeekPlanning Planning { get; private set; }
    public bool IsDefintief { get; private set; } = false;
    public IList<EenheidVanLeeruitkomsten> Evls { get; } = new List<EenheidVanLeeruitkomsten>();
    public IList<TentamenInrichting> Tentamen { get; } = new List<TentamenInrichting>();
    public IList<LesInrichting> Lessen { get; } = new List<LesInrichting>();
    
    public void MaakDefintief()
    {
        IsDefintief = true;
    }

    public void AddEenheidVanLeeruitkomsten(EenheidVanLeeruitkomsten eenheidVanLeeruitkomsten)
    {
        Evls.Add(eenheidVanLeeruitkomsten);
    }
    
    public void AddTentamen(TentamenInrichting tentamenInrichting)
    {
        Tentamen.Add(tentamenInrichting);
    }

    public void AddLes(LesInrichting lesInrichting)
    {
        Lessen.Add(lesInrichting);
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
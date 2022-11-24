using System.ComponentModel.DataAnnotations.Schema;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Domain;

public class CourseWeekUitvoering
{
    public int Id { get; set; }
    public DateTimeOffset Monday { get; init; }
    private CourseWeekInrichting _courseWeekInrichting { get; set; }
    [NotMapped]
    public CourseWeekInrichting CourseWeekInrichting
    {
        get
        {
            return this._courseWeekInrichting;
        }
        init
        {
            this._courseWeekInrichting = value;
            creeerTentamen();
            creeerLessen();
        }
    }
    public IList<TentamenUitvoering> Tentamen { get; } = new List<TentamenUitvoering>();
    public IList<LesUitvoering> Lessen { get; } = new List<LesUitvoering>();
    
    private void creeerTentamen()
    {
        foreach (TentamenInrichting tentamen in _courseWeekInrichting.Tentamen)
        {
            Tentamen.Add(new TentamenUitvoering
            {
                TentamenInrichting = tentamen
            });
        }
    }

    private void creeerLessen()
    {
        foreach (LesInrichting les in _courseWeekInrichting.Lessen)
        {
            Lessen.Add(new LesUitvoering
            {
                    LesInrichting = les
            });
        }
    }
}
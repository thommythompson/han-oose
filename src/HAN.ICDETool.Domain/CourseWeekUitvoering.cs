using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Domain;

public class CourseWeekUitvoering
{
    public DateOnly? Monday { get; private set; }
    private CourseWeekInrichting _inrichting { get; set; }
    private IList<TentamenUitvoering> _tentamen { get; set; } = new List<TentamenUitvoering>();
    private IList<LesUitvoering> _lessen { get; set; } = new List<LesUitvoering>();

    public CourseWeekUitvoering(CourseWeekInrichting inrichting, DateOnly date)
    {
        _inrichting = inrichting;
        Monday = date.StartOfWeek();
        
        creeerTentamen();
        creeerLessen();
    }

    private void creeerTentamen()
    {
        foreach (TentamenInrichting tentamen in _inrichting.Tentamen)
        {
            _tentamen.Add(new TentamenUitvoering(tentamen));
        }
    }

    private void creeerLessen()
    {
        foreach (LesInrichting les in _inrichting.Lessen)
        {
            _lessen.Add(new LesUitvoering(les));
        }
    }
}
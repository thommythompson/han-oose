using System.ComponentModel.DataAnnotations.Schema;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Domain;

public class CourseWeekUitvoering
{
    public int Id { get; set; }
    public DateTimeOffset Maandag { get; }
    public CourseWeekInrichting CourseWeekInrichting { get; }
    public IEnumerable<TentamenUitvoering> Tentamen { get => _tentamen; }
    private IList<TentamenUitvoering> _tentamen { get; } = new List<TentamenUitvoering>();
    public IEnumerable<LesUitvoering> Lessen { get => _lessen; }
    private IList<LesUitvoering> _lessen { get; } = new List<LesUitvoering>();

    public CourseWeekUitvoering(DateTimeOffset maandag, CourseWeekInrichting courseWeekInrichting)
    {
        this.Maandag = maandag;
        this.CourseWeekInrichting = courseWeekInrichting;
        
        creeerTentamenUitvoeringen();
        creeerLesUitvoeringen();
    }
    
    private void creeerTentamenUitvoeringen()
    {
        foreach (SchriftelijkeToets schriftelijkeToets in CourseWeekInrichting.SchriftelijkeToets)
        {
            _tentamen.Add(new TentamenUitvoering(schriftelijkeToets));
        }

        foreach (BeroepsProduct beroepsProduct in CourseWeekInrichting.BeroepsProduct)
        {
            _tentamen.Add(new TentamenUitvoering(beroepsProduct));
        }
    }

    private void creeerLesUitvoeringen()
    {
        foreach (LesInrichting les in CourseWeekInrichting.Lessen)
        {
            _lessen.Add(new LesUitvoering(les));
        }
    }
}
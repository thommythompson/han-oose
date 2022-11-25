using System.ComponentModel.DataAnnotations.Schema;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Domain;

public class CourseWeekUitvoering
{
    public int Id { get; set; }
    public DateTimeOffset Monday { get; init; }
    
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
            creeerTentamenUitvoeringen();
            creeerLesUitvoeringen();
        }
    }
    private CourseWeekInrichting _courseWeekInrichting { get; set; }
    
    [NotMapped]
    public IEnumerable<TentamenUitvoering> Tentamen { get => _tentamen; }
    private IList<TentamenUitvoering> _tentamen { get; } = new List<TentamenUitvoering>();
    
    [NotMapped]
    public IEnumerable<LesUitvoering> Lessen { get => _lessen; }
    private IList<LesUitvoering> _lessen { get; } = new List<LesUitvoering>();

    private void creeerTentamenUitvoeringen()
    {
        foreach (SchriftelijkeToets schriftelijkeToets in _courseWeekInrichting.SchriftelijkeToets)
        {
            _tentamen.Add(new TentamenUitvoering
            {
                SchriftelijkeToets = schriftelijkeToets
            });
        }

        foreach (BeroepsProduct beroepsProduct in _courseWeekInrichting.BeroepsProduct)
        {
            _tentamen.Add(new TentamenUitvoering
            {
                BeroepsProduct = beroepsProduct
            });
        }
    }

    private void creeerLesUitvoeringen()
    {
        foreach (LesInrichting les in _courseWeekInrichting.Lessen)
        {
            _lessen.Add(new LesUitvoering
            {
                    LesInrichting = les
            });
        }
    }
}
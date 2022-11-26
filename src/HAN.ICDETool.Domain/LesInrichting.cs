using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class LesInrichting : Validator
{
    public int Id { get; set; }
    public string Titel { get; set;  }
    public IEnumerable<LesMateriaal> LesMateriaal { get => _lesMateriaal; }
    private IList<LesMateriaal> _lesMateriaal { get; } = new List<LesMateriaal>();
    public int CourseWeekInrichtingId { get; set; }
    public int LeerdoelId { get; set; }

    public LesInrichting(string titel)
    {
        this.Titel = titel;
    }
    
    public void AddLesMateriaal(LesMateriaal lesMateriaal)
    {
        _lesMateriaal.Add(lesMateriaal);
    }

    public void RemoveLesMateriaal(LesMateriaal lesMateriaal)
    {
        _lesMateriaal.Remove(lesMateriaal);
    }

    public void validate()
    {
        throw new NotImplementedException();
    }
}
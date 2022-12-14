using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class Klas : BaseEntity
{
    public int Id { get; set; }
    public String Code { get; set; }
    public Persoon? Mentor { get; set; }
    public int? DocentId { get; set; }
    [BackingField(nameof(_studenten))]
    public IEnumerable<Persoon>? Studenten { get => _studenten; }
    private IList<Persoon>? _studenten { get; set;  } = new List<Persoon>();

    public Klas(string code)
    {
        this.Code = code;
    }
    
    public void AddStudent(Persoon student)
    {
        _studenten.Add(student);
    }
    
    public void Removetudent(Persoon student)
    {
        _studenten.Remove(student);
    }
}
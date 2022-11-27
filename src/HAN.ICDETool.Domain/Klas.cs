using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Domain;

public class Klas
{
    public int Id { get; set; }
    public String Code { get; set; }
    public int? DocentId { get; set; }
    [BackingField(nameof(_studenten))]
    public IEnumerable<Student>? Studenten { get => _studenten; }
    private IList<Student>? _studenten { get; } = new List<Student>();

    public Klas(string code)
    {
        this.Code = code;
    }
    
    public void AddStudent(Student student)
    {
        _studenten.Add(student);
    }
    
    public void Removetudent(Student student)
    {
        _studenten.Remove(student);
    }
}
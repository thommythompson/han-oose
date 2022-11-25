using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class Klas
{
    public int Id { get; set; }
    public String Code { get; init; }
    public Docent Mentor { get; init; }
    
    [NotMapped]
    public IEnumerable<Student> Studenten { get => _studenten; }
    private IList<Student> _studenten { get; } = new List<Student>();
    
    public void AddStudent(Student student)
    {
        _studenten.Add(student);
    }
}
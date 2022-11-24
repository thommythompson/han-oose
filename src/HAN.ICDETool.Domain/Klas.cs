namespace HAN.ICDETool.Domain;

public class Klas
{
    public int Id { get; set; }
    public String Code { get; init; }
    public Docent Mentor { get; init; }
    public IList<Student> Studenten { get; } = new List<Student>();

    public void AddStudent(Student student)
    {
        Studenten.Add(student);
    }
}
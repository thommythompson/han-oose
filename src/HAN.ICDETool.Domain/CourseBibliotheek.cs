using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Domain;

public class CourseBibliotheek
{
    public int Id { get; set; }
    [BackingField(nameof(_courses))]
    public IEnumerable<CourseInrichting> Courses { get => _courses; } 
    private IList<CourseInrichting> _courses { get; } = new List<CourseInrichting>();
    
    public void AddCourse(CourseInrichting courseInrichting)
    {
        _courses.Add(courseInrichting);
    }

    public void RemoveCourse(CourseInrichting courseInrichting)
    {
        _courses.Remove(courseInrichting);
    }
}
using Ardalis.Specification;
using HAN.ICDETool.Core.Entities;

namespace HAN.ICDETool.Core.Specifications;

public class BeoordelingByStudentId : Specification<Beoordeling>
{
    public BeoordelingByStudentId(int studentId)
    {
        Query.Include(e => e.TentamenUitvoering)
            .Include(e => e.Docent)
            .Include(e => e.Student)
            .Where(e => e.StudentId == studentId);
    }
}
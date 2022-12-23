using Ardalis.Specification;
using HAN.ICDETool.Core.Entities;

namespace HAN.ICDETool.Core.Specifications;

public class SingleCourseInrichtingWithReferences : Specification<CourseInrichting>
{
    public SingleCourseInrichtingWithReferences(int id)
    {
        Query.Where(e => e.Id == id)
            .Include(e => e.Planning)
            .ThenInclude(e => e.Weken)
            .ThenInclude(e => e.Lessen)
            .Include(e => e.Planning)
            .ThenInclude(e => e.Weken)
            .ThenInclude(e => e.SchriftelijkeToets)
            .Include(e => e.Planning)
            .ThenInclude(e => e.Weken)
            .ThenInclude(e => e.BeroepsProduct);
    }
}
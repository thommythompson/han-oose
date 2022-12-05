using Ardalis.Specification;
using HAN.ICDETool.Core.Entities;

namespace HAN.ICDETool.Core.Specifications;

public class SingleCourseUitvoeringWithReferences : Specification<CourseUitvoering>
{
    public SingleCourseUitvoeringWithReferences(int id)
    {
        Query.Where(e => e.Id == id)
            .Include(e => e.Weken)
            .ThenInclude(e => e.Lessen)
            .Include(e => e.Weken)
            .ThenInclude(e => e.Tentamen);
    }
}
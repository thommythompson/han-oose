using Ardalis.Specification;
using HAN.ICDETool.Core.Entities;

namespace HAN.ICDETool.Core.Specifications;

public class LesInrichtingWithReferences : Specification<LesInrichting>
{
    public LesInrichtingWithReferences()
    {
        Query.Include(e => e.LesMateriaal)
            .Include(e => e.Leerdoel);
    }
}
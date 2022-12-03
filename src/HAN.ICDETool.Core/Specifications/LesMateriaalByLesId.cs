using Ardalis.Specification;
using HAN.ICDETool.Core.Entities;

namespace HAN.ICDETool.Core.Specifications;

public class LesMateriaalByLesId : Specification<LesMateriaal>
{
    public LesMateriaalByLesId(int lesId)
    {
        Query.Where(t => t.Id == lesId);
    }
}
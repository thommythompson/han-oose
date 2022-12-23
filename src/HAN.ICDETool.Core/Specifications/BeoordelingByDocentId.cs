using Ardalis.Specification;
using HAN.ICDETool.Core.Entities;

namespace HAN.ICDETool.Core.Specifications;

public class BeoordelingByDocentId : Specification<Beoordeling>
{
    public BeoordelingByDocentId(int docentId)
    {
        Query.Include(e => e.TentamenUitvoering)
            .Include(e => e.Docent)
            .Include(e => e.Student)
            .Where(e => e.DocentId == docentId);
    }
}
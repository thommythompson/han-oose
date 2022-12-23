using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAN.ICDETool.Core.Entities;

public class LesMateriaal : BaseEntity
{
    public int Id { get; set; }
    [BackingField(nameof(_inhoud))]
    public IEnumerable<LesMateriaalLine>? Inhoud { get => _inhoud; }

    private IList<LesMateriaalLine>? _inhoud { get; set; } = new List<LesMateriaalLine>();
    public int LesInrichtingId { get; set; }
    
    public LesMateriaal()
    {
        _inhoud = genereerInhoud();
    }

    private IList<LesMateriaalLine> genereerInhoud()
    {
        IList<LesMateriaalLine> list = new List<LesMateriaalLine>();
        
        list.Add(new LesMateriaalLine("Titel"));
        list.Add(new LesMateriaalLine("Inleiding"));
        list.Add(new LesMateriaalLine("Paragraag 1"));
        list.Add(new LesMateriaalLine("Paragraag 2"));
        list.Add(new LesMateriaalLine("Slot"));

        return list;
    }
}
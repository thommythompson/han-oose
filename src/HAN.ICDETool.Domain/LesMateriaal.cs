using System.ComponentModel.DataAnnotations.Schema;

namespace HAN.ICDETool.Domain;

public class LesMateriaal
{
    public int Id { get; set; }
    public IEnumerable<LesMateriaalLine> Inhoud { get => _inhoud; }
    private IList<LesMateriaalLine> _inhoud { get; }

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
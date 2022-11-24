namespace HAN.ICDETool.Domain;

public class LesMateriaal
{
    public int Id { get; set; }
    public IList<LesMateriaalLine> Inhoud { get; private set; }

    public LesMateriaal()
    {
        Inhoud = genereerInhoud();
    }

    private IList<LesMateriaalLine> genereerInhoud()
    {
        IList<LesMateriaalLine> list = new List<LesMateriaalLine>();
        
        list.Add(new LesMateriaalLine { Line = "Titel"});
        list.Add(new LesMateriaalLine { Line = "Inleiding"});
        list.Add(new LesMateriaalLine { Line = "Paragraag 1"});
        list.Add(new LesMateriaalLine { Line = "Paragraag 2"});
        list.Add(new LesMateriaalLine { Line = "Slot"});

        return list;
    }
}
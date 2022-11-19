namespace HAN.ICDETool.Domain;

public class LesUitvoering
{
    private LesInrichting _inrichting { get; set; }
    private Persoon? _docent { get; set; }
    private Locatie? _locatie { get; set; }

    public LesUitvoering(LesInrichting inrichting)
    {
        _inrichting = inrichting;
    }
}
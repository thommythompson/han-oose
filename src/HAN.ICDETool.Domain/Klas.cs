namespace HAN.ICDETool.Domain;

public class Klas
{
    private String? _code { get; set; }
    private Persoon _mentor { get; set; }
    private IList<Persoon> _studenten { get; set; }
}
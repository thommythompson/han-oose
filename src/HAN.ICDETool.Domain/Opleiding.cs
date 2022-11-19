namespace HAN.ICDETool.Domain;

public class Opleiding
{
    private String? _naam { get; set; }
    private String? _code { get; set; }
    private IList<OpleidingsProfiel> _profielen { get; set; }
}
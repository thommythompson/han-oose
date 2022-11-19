namespace HAN.ICDETool.Domain;

public class EenheidVanLeeruitkomsten
{
    private String? _titel { get; set; }
    private String? _omschrijving { get; set; }
    private IList<Leeruitkomst>? _leeruitkomsten { get; set; }
}
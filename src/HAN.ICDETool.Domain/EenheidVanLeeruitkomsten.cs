namespace HAN.ICDETool.Domain;

public class EenheidVanLeeruitkomsten
{
    private String? titel { get; set; }
    private String? omschrijving { get; set; }
    private IList<Leeruitkomst>? leeruitkomsten { get; set; }
}
namespace HAN.ICDETool.Domain;

public class Adres
{
    public int Id { get; set; }
    public String Straat { get; init; }
    public String Huisnummer { get; init; }
    public String? _Toevoeging { get; init; }
    public String Postcode { get; init; }
    public String Plaatsnaam { get; init; }
}
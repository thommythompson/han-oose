namespace HAN.ICDETool.Domain;

public class Adres
{
    public int Id { get; set; }
    public String Straat { get; set; }
    public String Huisnummer { get; set; }
    public String? Toevoeging { get; set; }
    public String Postcode { get; set; }
    public String Plaatsnaam { get; set; }
    public int LocatieId { get; set; }

    public Adres(string straat, string huisnummer, string postcode, string plaatsnaam, string toevoeging = null)
    {
        this.Straat = straat;
        this.Huisnummer = huisnummer;
        this.Postcode = postcode;
        this.Plaatsnaam = plaatsnaam;
        this.Toevoeging = toevoeging;
    }
}
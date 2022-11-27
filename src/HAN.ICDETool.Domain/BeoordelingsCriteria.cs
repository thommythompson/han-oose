namespace HAN.ICDETool.Domain;

public class BeoordelingsCriteria
{
    public int Id { get; set; }
    public String Omschrijving { get; set; }
    public int RubricId { get; set; }

    public BeoordelingsCriteria(string omschrijving)
    {
        this.Omschrijving = omschrijving;
    }
}
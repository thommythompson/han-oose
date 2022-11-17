namespace HAN.ICDETool.Domain;

public class Rubrics
{
    private String? titel { get; set; }
    private int? weging { get; set; }
    private int? voldoendeThreshold { get; set; }
    private int? knockoutThreshold { get; set; }
    private IList<Leerdoel>? leerdoelen { get; set; }
    private IList<BeoordelingsCriteria>? criteria { get; set; }

    
    public Rubrics(int aantalCriteria)
    {
        
    }

    private void vulCriteria(int aantal)
    {
        for (int i = 0; i < aantal; i++)
        {
            criteria.Add(new BeoordelingsCriteria());
        }
    }
}
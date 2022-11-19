namespace HAN.ICDETool.Domain;

public class Rubric
{
    private String? _titel { get; set; }
    private int? _weging { get; set; }
    private int? _voldoendeThreshold { get; set; }
    private int? _knockoutThreshold { get; set; }
    private IList<Leerdoel>? _leerdoelen { get; set; }
    private IList<BeoordelingsCriteria>? _criteria { get; set; }

    public Rubric(int aantalCriteria)
    {
        vulCriteria(aantalCriteria);
    }

    private void vulCriteria(int aantal)
    {
        for (int i = 0; i < aantal; i++)
        {
            _criteria.Add(new BeoordelingsCriteria());
        }
    }
}
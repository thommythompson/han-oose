using HAN.ICDETool.Domain.Constanten;

namespace HAN.ICDETool.Domain;

public class CourseInrichting
{
    private String _titel;
    private int _aantalHaalbareStudiePunten;
    private CourseWeekPlanning _planning;
    private IList<EenheidVanLeeruitkomsten> _evls = new List<EenheidVanLeeruitkomsten>();
    private bool _isDefinitief = false;

    public CourseInrichting(String titel, TijdsEenheid duur)
    {
        _titel = titel;
        _aantalHaalbareStudiePunten = duur.getHaalbareStudiePunten();
        _planning = new CourseWeekPlanning(duur);
    }

    public void AddEenheidVanLeeruikomsten(string titel, string omschrijving)
    {
        _evls.Add(new EenheidVanLeeruitkomsten(titel, omschrijving));
    }

    public void MaakDefintief()
    {
        _isDefinitief = true;
    }

    public bool IsDefintief()
    {
        return _isDefinitief;
    }

    public string GetTitel()
    {
        return _titel;
    }
}
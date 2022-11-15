using System.Collections.Immutable;

namespace HAN.ICDETool.Domain;

using HAN.ICDETool.Domain.Constanten;

public class CourseWeekPlanning
{
    private TijdsEenheid _courseDuur;
    private IList<CourseWeekInrichting> _weekPlanning = new List<CourseWeekInrichting>();

    public CourseWeekPlanning(TijdsEenheid courseDuur)
    {
        _courseDuur = courseDuur;

        VulWeekPlanning(courseDuur.getDuurInWeken());
    }

    private void VulWeekPlanning(int aantalWeken)
    {
        for(int i = 0; i < aantalWeken; i++)
        {
            _weekPlanning.Add(new CourseWeekInrichting());
        }
    }
}
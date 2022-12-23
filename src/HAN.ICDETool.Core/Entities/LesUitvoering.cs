namespace HAN.ICDETool.Core.Entities;

public class LesUitvoering : BaseEntity
{
    public int Id { get; set; }
    public LesInrichting LesInrichting { get; }
    public Persoon? Docent { get; set; }
    public int? DocentId { get; set; }
    public Locatie? Locatie { get; set; }
    public int? LocatieId { get; set; }
    public CourseWeekUitvoering CourseWeekUitvoering { get; set; }
    public int CourseWeekUitvoeringId { get; set; }

    // EF Core constructor: EF Core does not support navigation types in the constructor
    private LesUitvoering() { }

    public LesUitvoering(LesInrichting lesInrichting) : this()
    {
        this.LesInrichting = lesInrichting;
    }
}
namespace HAN.ICDETool.Services.ResponseDtos;

public class CourseInrichtingResponseDto : BaseResponseDto
{
    public int Id { get; set; }
    public String Titel { get; set; }
    public String Omschrijving { get; set; }
    // public DocentRepsonseDto AangemaaktDoor { get; set; }
    // public CourseWeekPlanningRepsonseDto? Planning { get; set; }
    public bool IsDefintief { get; set; }
    public DateTimeOffset AanmaakDatum { get; set; }
    // public IEnumerable<EenheidVanLeeruitkomstenRepsonseDto>? Evls { get; set; }
    // public IEnumerable<BeroepsProductRepsonseDto>? BeroepsProducten { get; set; }
    // public IEnumerable<SchriftelijkeToetsRepsonseDto>? Toetsen { get; set; }
    // public IEnumerable<LesInrichtingRepsonseDto>? Lessen { get; set; }
    // public IEnumerable<CourseUitvoeringRepsonseDto>? CourseUitvoeringen { get; set; }
}
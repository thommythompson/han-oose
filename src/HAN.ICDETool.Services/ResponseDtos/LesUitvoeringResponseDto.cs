namespace HAN.ICDETool.Services.ResponseDtos;

public class LesUitvoeringResponseDto : BaseResponseDto
{
    public int Id { get; set; }
    public LesInrichtingResponseDto LesInrichting { get; }
    // public DocentResponseDto Docent { get; set; }
    public int DocentId { get; set; }
    // public LocatieResponseDto Locatie { get; set; }
    public int LocatieId { get; set; }
    public CourseWeekUitvoeringResponseDto CourseWeekUitvoering { get; set; }
    public int CourseWeekUitvoeringId { get; set; }
}
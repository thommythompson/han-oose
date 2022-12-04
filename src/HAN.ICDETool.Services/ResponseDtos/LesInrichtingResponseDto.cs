namespace HAN.ICDETool.Services.ResponseDtos;

public class LesInrichtingResponseDto : BaseResponseDto
{
    public int Id { get; set; }
    public string Titel { get; set; }
    public IEnumerable<LesMateriaalResponseDto> LesMateriaal { get; set;  }
    public int CourseWeekInrichtingId { get; set; }
    public int CourseInrichtingId { get; set; }
    public LeerdoelResponseDto Leerdoel { get; set; }
    public int LeerdoelId { get; set; }
}
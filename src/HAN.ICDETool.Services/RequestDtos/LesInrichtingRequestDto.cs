namespace HAN.ICDETool.Services.RequestDtos;

public class LesInrichtingRequestDto
{
    public string Titel { get; set; }
    public IEnumerable<LesMateriaalRequestDto> LesMateriaal { get; set;  }
    public int CourseWeekInrichtingId { get; set; }
    public int CourseInrichtingId { get; set; }
    public LeerdoelRequestDto Leerdoel { get; set; }
    public int LeerdoelId { get; set; }
}
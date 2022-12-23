namespace HAN.ICDETool.Services.ResponseDtos;

public class CourseUitvoeringResponseDto : BaseResponseDto
{
    public int Id { get; set; }
    public CourseInrichtingResponseDto CourseInrichting { get; set; }
    public int CourseInrichtingId { get; set; }
    public DateTimeOffset StartDatum { get; set; }
    public IEnumerable<CourseWeekUitvoeringResponseDto> Weken { get; set; }
}
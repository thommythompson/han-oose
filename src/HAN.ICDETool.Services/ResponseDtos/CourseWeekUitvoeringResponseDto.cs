namespace HAN.ICDETool.Services.ResponseDtos;

public class CourseWeekUitvoeringResponseDto : BaseResponseDto
{
    public int Id { get; set; }
    public DateTimeOffset Maandag { get; set; }
    // public CourseWeekInrichtingResponseDto CourseWeekInrichting { get; set; }
    public int CourseWeekInrichtingId { get; set; }
    public IEnumerable<TentamenUitvoeringResponseDto>? Tentamen { get; set; }
    public IEnumerable<LesUitvoeringResponseDto>? Lessen { get; set; }
    public int CourseUitvoeringId { get; set; }
}
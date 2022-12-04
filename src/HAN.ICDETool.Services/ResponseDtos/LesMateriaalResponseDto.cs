namespace HAN.ICDETool.Services.ResponseDtos;

public class LesMateriaalResponseDto : BaseResponseDto
{
    public IEnumerable<LesMateriaalLineResponseDto> Inhoud { get; set; }
    public int LesInrichtingId { get; set; }
}
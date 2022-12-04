namespace HAN.ICDETool.Services.ResponseDtos;

public class LesMateriaalResponseDto : BaseResponseDto
{
    public int Id { get; set; }
    public IEnumerable<LesMateriaalLineResponseDto> Inhoud { get; set; }
    public int LesInrichtingId { get; set; }
    
}
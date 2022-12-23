namespace HAN.ICDETool.Services.RequestDtos;

public class LesMateriaalRequestDto 
{
    public IEnumerable<LesMateriaalLineRequestDto> Inhoud { get; set; }
    public int LesInrichtingId { get; set; }
}
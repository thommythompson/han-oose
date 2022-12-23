namespace HAN.ICDETool.Services.ResponseDtos;

public class BeoordelingResponseDto : BaseResponseDto
{
    public int Id { get; set; }
    public TentamenUitvoeringResponseDto TentamenUitvoering { get; set; }
    public int TentamenUitvoeringId { get; set; }
    public string StudentNaam { get; set; }
    public int StudentId { get; set; }
    public string DocentNaam { get; set; }
    public int DocentId { get; set; }
}
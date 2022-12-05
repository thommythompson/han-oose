namespace HAN.ICDETool.Services.ResponseDtos;

public class TentamenUitvoeringResponseDto : BaseResponseDto
{
    public int Id { get; set; }
    // public SchriftelijkeToetsResponseDto SchriftelijkeToets { get; init; }
    public int SchriftelijkeToetsId { get; init; }
    // public BeroepsProductResponseDto BeroepsProduct { get; init; }
    public int BeroepsProductId { get; init; }
    // public LocatieResponseDto Locatie { get; set; }
    public int LocatieId { get; set; }
    // public DocentResponseDto Docent { get; set; }
    public int DocentId { get; set; }
    public CourseWeekUitvoeringResponseDto CourseWeekUitvoering { get; set; }
    public int CourseUitvoeringId { get; set; }
    // public IEnumerable<BeoordelingResponseDto> Beoordelingen { get; set; }
}
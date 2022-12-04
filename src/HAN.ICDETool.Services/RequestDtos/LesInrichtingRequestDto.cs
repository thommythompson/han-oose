using System.ComponentModel.DataAnnotations;

namespace HAN.ICDETool.Services.RequestDtos;

public class LesInrichtingRequestDto
{
    [Required]
    [MaxLength(50, ErrorMessage = "Titel is te lang, maximaal 50 karakters toegestaan")]
    public string Titel { get; set; }
    public int CourseWeekInrichtingId { get; set; }
    [Required]
    public int CourseInrichtingId { get; set; }
    [Required]
    public int LeerdoelId { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace HAN.ICDETool.Services.RequestDtos;

public class LesMateriaalLineRequestDto
{
    [Required]
    public string Line { get; set; }
    [Required]
    public int LesMateriaalId { get; set; }
}
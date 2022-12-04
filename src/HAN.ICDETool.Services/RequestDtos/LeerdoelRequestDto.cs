using System.ComponentModel.DataAnnotations;

namespace HAN.ICDETool.Services.RequestDtos;

public class LeerdoelRequestDto
{
    [Required]
    [MinLength(5, ErrorMessage = "Titel is te kort, minimaal 5 karakters vereist")]
    [MaxLength(50, ErrorMessage = "Titel is te lang, maximaal 50 karakters toegestaan")]
    public string Titel { get; set; }
    [Required]
    [MinLength(5, ErrorMessage = "Omschrijving is te kort, minimaal 5 karakters vereist")]
    [MaxLength(250, ErrorMessage = "Omschrijving is te lang, maximaal 50 karakters toegestaan")]
    public string Omschrijving { get; set; }
}
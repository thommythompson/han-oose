using System.ComponentModel.DataAnnotations;
using HAN.ICDETool.SharedKernel;

namespace HAN.ICDETool.Services.RequestDtos;

public class ExportFormaatDto
{
    [Required] 
    [ValidValues("pdf", "csv", "docx", ErrorMessage = "Invalid value, valid values are: pdf, csv & docx")]
    public string ExportType { get; set; }
}
namespace HAN.ICDETool.Web.Models;

using System.ComponentModel.DataAnnotations;

public class Credentials
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}
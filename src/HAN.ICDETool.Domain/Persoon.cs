using System.Runtime.Versioning;

namespace HAN.ICDETool.Domain;

public class Persoon
{
    public String? voornaam { get; set; }
    public String? achternaam { get; set; }
    public String? email { get; set; }
    public Rol? rol { get; set; }
}

public enum Rol
{
    Student, Docent
}
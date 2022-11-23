namespace HAN.ICDETool.Domain;

public class LesMateriaal
{
    public int Id { get; set; }
    public IList<String> lesInhoud { get; private set; } = new List<string>();

    public LesMateriaal(string titel, string inhoud)
    {
        lesInhoud.Add(titel);
        lesInhoud.Add(inhoud);
    }
}
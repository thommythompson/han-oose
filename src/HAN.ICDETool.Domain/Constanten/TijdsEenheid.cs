namespace HAN.ICDETool.Domain.Constanten;

public abstract class TijdsEenheid
{
    public static int duurInWeken;
    public static int haalbareStudiepunten;

    public int getDuurInWeken()
    {
        return duurInWeken;
    }

    public int getHaalbareStudiePunten()
    {
        return haalbareStudiepunten;
    }
}
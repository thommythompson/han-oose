namespace HAN.ICDETool.SharedKernel;

public static class DateOnlyExtensions
{
    public static DateOnly StartOfWeek(this DateOnly date)
    {
        DayOfWeek startOfWeek = DayOfWeek.Monday;
        int diff = (7 + (date.DayOfWeek - startOfWeek)) % 7;
        return date.AddDays(-1 * diff);
    }
}
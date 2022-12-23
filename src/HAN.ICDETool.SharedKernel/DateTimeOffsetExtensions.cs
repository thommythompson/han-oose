namespace HAN.ICDETool.SharedKernel;

public static class DateTimeOffsetExtensions
{
    public static DateTimeOffset GetMondayOfThisWeek(this DateTimeOffset date)
    {
        DayOfWeek startOfWeek = DayOfWeek.Monday;
        int diff = (7 + (date.DayOfWeek - startOfWeek)) % 7;
        return date.AddDays(-1 * diff);
    }
}
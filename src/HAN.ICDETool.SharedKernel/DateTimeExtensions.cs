namespace HAN.ICDETool.SharedKernel;

public static class DateTimeExtensions
{
    public static DateOnly ToDateOnly(this DateTime dt)
    {
        return new DateOnly(dt.Year, dt.Month, dt.Day);
    }
}
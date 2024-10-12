namespace Timezone.Core.Services;

public static class DateTimeExtensions
{
    public static DateTime ConvertToUtc(this DateTime dateTime, TimeZoneInfo timezone)
    {
        var dateTimeWithKind = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);

        return TimeZoneInfo.ConvertTimeToUtc(dateTimeWithKind, timezone);
    }
}

namespace Timezone.Core.Services;

public static class TimezoneHelper
{
    public static TimeZoneInfo? GetTimezone(string? timezoneId)
    {
        if (timezoneId is null)
        {
            return null;
        }

        TimeZoneInfo.TryFindSystemTimeZoneById(timezoneId, out var timezone);
        return timezone;
    }
}

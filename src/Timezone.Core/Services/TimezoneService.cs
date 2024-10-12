namespace Timezone.Core.Services;

using Models;

public class TimezoneService : ITimezoneService
{
    public IEnumerable<TimeZoneInfo> GetTimezones() => TimeZoneInfo.GetSystemTimeZones();

    public TimeZoneInfo? GetTimezone(string timezoneId)
    {
        return TimezoneHelper.GetTimezone(timezoneId);
    }

    public DateTime ConvertFromOneTimezoneToAnother(TimeZoneConversionDomain request)
    {
        ValidateRequest(request);

        var dateTime = DateTime.SpecifyKind(request.DateTime, DateTimeKind.Unspecified);
        var dateTimeUtc = dateTime.ConvertToUtc(request.FromTimezone);
        var dateTimeConverted = TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc, request.ToTimezone);

        return dateTimeConverted;
    }

    private static void ValidateRequest(TimeZoneConversionDomain request)
    {
        if (request.DateTime == DateTime.MinValue)
        {
            throw new ArgumentException("DateTime is required.");
        }

        if (request.FromTimezone == null)
        {
            throw new ArgumentException("FromTimezone provided is invalid. Please provide a valid timezone.");
        }

        if (request.ToTimezone is null)
        {
            throw new ArgumentException("ToTimezone provided is invalid. Please provide a valid timezone.");
        }
    }
}

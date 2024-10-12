namespace Timezone.Core.Services;

using Models;

public interface ITimezoneService
{
    DateTime ConvertFromOneTimezoneToAnother(TimeZoneConversionDomain request);
    IEnumerable<TimeZoneInfo> GetTimezones();
    TimeZoneInfo? GetTimezone(string timezoneId);
}

namespace Timezone.Core.Models;

public class TimeZoneConversionDomain
{
    public DateTime DateTime { get; set; }
    public TimeZoneInfo FromTimezone { get; set; }
    public TimeZoneInfo ToTimezone { get; set; }
}

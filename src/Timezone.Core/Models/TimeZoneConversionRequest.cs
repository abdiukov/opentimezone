namespace Timezone.Core.Models;

public class TimeZoneConversionRequest
{
    public DateTime DateTime { get; set; }
    public string? FromTimezone { get; set; }
    public string? ToTimezone { get; set; }
}

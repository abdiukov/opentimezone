namespace TimezoneWebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using Timezone.Core.Extensions;
using Timezone.Core.Models;
using Timezone.Core.Services;

[ApiController]
public class TimezoneController(ITimezoneService timezoneService) : Controller
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TimezoneResponse))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Route("timezone/{*timezoneId}")]
    public async Task<IActionResult> GetTimezone(string timezoneId)
    {
        var timezone = timezoneService.GetTimezone(timezoneId);

        return timezone is null
            ? NotFound()
            : Ok(timezone.ToResponse());
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [Route("timezones")]
    public async Task<IEnumerable<TimezoneResponse>> GetTimezones()
    {
        var timezones = timezoneService.GetTimezones();

        return timezones.ToResponse();
    }
}

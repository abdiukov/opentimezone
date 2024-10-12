namespace TimezoneWebApi.Controllers;

using Examples;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using Timezone.Core.Extensions;
using Timezone.Core.Models;
using Timezone.Core.Services;

[ApiController]
[Route("[controller]")]
public class ConvertController(ITimezoneService timezoneService) : Controller
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type= typeof(DateTime))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorModel))]
    [SwaggerRequestExample(typeof(TimeZoneConversionRequest), typeof(PostConvertExamples))]
    public async Task<DateTime> ConvertTime(TimeZoneConversionRequest request)
    {
        var domain = request.ToDomain();

        var response = timezoneService.ConvertFromOneTimezoneToAnother(domain);

        return response;
    }
}

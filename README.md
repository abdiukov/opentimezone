# OpenTimezone API
This is a simple open-source timezone API, that can convert time between different time zones

- **Convert timezones**: Convert times between different timezones.
- **Free and Unrestricted**: No cost, no API limits, no API key needed.

OpenTimezone API is currently deployed without any restrictions at https://api.opentimezone.com.

## How to run locally:

### Getting started
Development requirements are the following:
- Visual Studio 2022 
    - with `ASP.NET and web development` installed from Visual Studio Installer
- .NET 8 SDK

To run the API:
1. Open the solution in Visual Studio 2022. 
2. Build and launch the Timezone.WebApi project.
3. API can be accessed at:
    - localhost:5280

### How to run functional tests
To run unit functional tests, you need to run WebApi project and then run the functional tests.

1. Build the solution
2. Open Terminal 
3. Navigate to the path `/src/Timezone.WebApi`
4. Run command: `dotnet run`
5. Open Visual Studio (or any other test runner) and run the functional tests.

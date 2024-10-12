// namespace Timezone.FunctionalTests.StepDefinitions;
//
// using System.Drawing;
// using System.Globalization;
// using NUnit.Framework;
// using RestSharp;
// using Support;
// using TechTalk.SpecFlow;
// using Timezone.Core.Models;
//
// [Binding]
// public class TimezoneSteps(ScenarioContext context) : TestBase(context)
// {
//     private TimezoneRequest _request;
//     private RestResponse _response;
//
//     [Given(@"I have a timezone request with following parameters:")]
//     public void GivenIHaveATimezoneRequestWithFollowingParameters(Table table)
//     {
//         var row = table.Rows[0];
//
//         _request = new TimezoneRequest
//         {
//             Text = row["Text"],
//             Width = string.IsNullOrEmpty(row["Width"]) ? null : int.Parse(row["Width"], CultureInfo.InvariantCulture),
//             Height = string.IsNullOrEmpty(row["Height"]) ? null : int.Parse(row["Height"], CultureInfo.InvariantCulture),
//             Difficulty = string.IsNullOrEmpty(row["Difficulty"]) ? null
//                 : Enum.Parse<TimezoneDifficulty>(row["Difficulty"], true)
//         };
//     }
//
//     [When(@"I send the request to the Create endpoint of the TimezoneController")]
//     public async Task WhenISendTheRequestToTheCreateEndpointOfTheTimezoneController()
//     {
//         var request = new RestRequest("timezone") // calls localhost/timezone
//         { RequestFormat = DataFormat.Json, Method = Method.Post };
//         request.AddJsonBody(_request);
//         _response = await Client.ExecuteAsync(request);
//     }
//
//     [Then(@"I expect a timezone image to be returned with the following attributes:")]
//     public void ThenIExpectATimezoneImageToBeReturnedWithTheFollowingAttributes(Table table)
//     {
//         var row = table.Rows[0];
//         using var ms = new MemoryStream(_response.RawBytes);
//         var img = Image.FromStream(ms);
//
//         var expectedWidth = int.Parse(row["Width"], CultureInfo.InvariantCulture);
//         var expectedHeight = int.Parse(row["Height"], CultureInfo.InvariantCulture);
//
//         Assert.That(img.Width, Is.EqualTo(expectedWidth));
//         Assert.That(img.Height, Is.EqualTo(expectedHeight));
//     }
//
//     [Then(@"I expect a timezone image to be returned without any black borders")]
//     public void ThenIExpectATimezoneImageToBeReturnedWithoutAnyBlackBorders()
//     {
//         using var ms = new MemoryStream(_response.RawBytes);
//         var img = Image.FromStream(ms);
//         var bmp = new Bitmap(img);
//
//         for (var i = 0; i < bmp.Width; i++)
//         {
//             for (var j = 0; j < bmp.Height; j++)
//             {
//                 var pixel = bmp.GetPixel(i, j);
//
//                 // If either R or G or B is less than 100, then it's a dark color
//                 if (pixel.R < 100 || pixel.G < 100 || pixel.B < 100)
//                 {
//                     throw new AssertionException($"Black/Dark color found in the image. Hex: {pixel.Name}");
//                 }
//             }
//         }
//     }
// }

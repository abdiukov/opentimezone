// namespace Timezone.UnitTests.Services;
//
// using System.Threading.Tasks;
// using Timezone.Core.Models;
// using Timezone.Core.Services;
// using Microsoft.AspNetCore.Mvc;
// using NUnit.Framework;
//
// [TestFixture]
// public class TimezoneServiceTests
// {
//     [Test]
//     public async Task CreateTimezoneImageAsyncReturnsFileContentResultWithCorrectContentType()
//     {
//         // Arrange
//         var config = new TimezoneDomainModel
//         {
//             Text = "my text",
//             Width = 100,
//             Height = 100,
//             Difficulty = TimezoneDifficulty.Medium
//         };
//         var timezoneService = new TimezoneService();
//
//         // Act
//         var result = await timezoneService.CreateTimezoneImageAsync(config);
//
//         // Assert
//         Assert.That(result, Is.InstanceOf<FileContentResult>(), "Result should be a FileContentResult.");
//         Assert.Multiple(() =>
//         {
//             Assert.That(result.ContentType, Is.EqualTo("image/jpeg"), "ContentType should be image/jpeg.");
//             Assert.That(result.FileContents, Is.Not.Null, "FileContents should not be null.");
//         });
//         Assert.That(result.FileContents, Is.Not.Empty, "FileContents should have a size greater than 0.");
//     }
// }

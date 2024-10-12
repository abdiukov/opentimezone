// namespace Timezone.UnitTests.Models;
//
// using System;
// using NUnit.Framework;
// using Timezone.Core.Models;
//
// [TestFixture]
// public class TimezoneImageTests
// {
//     [Test]
//     public void TimezoneImageConstructedWithConfigGeneratesImageOfCorrectDimensions()
//     {
//         // Arrange
//         var config = new TimezoneDomainModel
//         {
//             Text = "text",
//             Width = 200,
//             Height = 100,
//             Font = "Arial",
//             Difficulty = TimezoneDifficulty.Easy
//         };
//
//         // Act
//         var timezoneImage = new TimezoneImage(config);
//         var created = timezoneImage.Create();
//         Assert.Multiple(() =>
//         {
//             // Assert
//             Assert.That(created.Width, Is.EqualTo(config.Width));
//             Assert.That(created.Height, Is.EqualTo(config.Height));
//         });
//     }
//
//     [Test]
//     public void TimezoneImageConstructedWithDifferentConfigGeneratesImageOfCorrectDimensions()
//     {
//         // Arrange
//         var config = new TimezoneDomainModel
//         {
//             Text = "text",
//             Width = 500,
//             Height = 300,
//             Font = "Arial",
//             Difficulty = TimezoneDifficulty.Hard
//         };
//
//         // Act
//         var timezoneImage = new TimezoneImage(config);
//         var created = timezoneImage.Create();
//         Assert.Multiple(() =>
//         {
//
//             // Assert
//             Assert.That(created.Width, Is.EqualTo(config.Width));
//             Assert.That(created.Height, Is.EqualTo(config.Height));
//         });
//     }
//
//     [Test]
//     public void TimezoneImageConstructedWithUnknownDifficultyThrowsArgumentOutOfRangeException()
//     {
//         // Arrange
//         var config = new TimezoneDomainModel
//         {
//             Text = "Test",
//             Width = 200,
//             Height = 100,
//             Font = "Arial",
//             Difficulty = (TimezoneDifficulty)999  // Any non-defined value
//         };
//
//         // Act & Assert
//         Assert.Throws<ArgumentOutOfRangeException>(() => new TimezoneImage(config).Create());
//     }
//
//
//     [Test]
//     public void TimezoneImageConstructedWithZeroWidthThrowsArgumentException()
//     {
//         // Arrange
//         var config = new TimezoneDomainModel()
//         {
//             Text = "Test",
//             Width = 0,
//             Height = 100,
//             Font = "Arial",
//             Difficulty = TimezoneDifficulty.Easy
//         };
//
//         // Act & Assert
//         Assert.Throws<ArgumentException>(() => new TimezoneImage(config).Create());
//     }
//
//     [Test]
//     public void TimezoneImageConstructedWithNegativeHeightThrowsArgumentException()
//     {
//         // Arrange
//         var config = new TimezoneDomainModel()
//         {
//             Text = "Test",
//             Width = 500,
//             Height = -100,
//             Font = "Arial",
//             Difficulty = TimezoneDifficulty.Easy
//         };
//
//         // Act & Assert
//         Assert.Throws<ArgumentException>(() => new TimezoneImage(config).Create());
//     }
//
//
//     [Test]
//     public void TimezoneImageConstructedWithValidConfigValueIsNotNull()
//     {
//         // Arrange
//         var config = new TimezoneDomainModel
//         {
//             Text = "Test",
//             Width = 200,
//             Height = 100,
//             Font = "Arial",
//             Difficulty = TimezoneDifficulty.Easy
//         };
//
//         // Act
//         var timezoneImage = new TimezoneImage(config);
//         var created = timezoneImage.Create();
//         // Assert
//         Assert.That(created, Is.Not.Null);
//     }
//
// }

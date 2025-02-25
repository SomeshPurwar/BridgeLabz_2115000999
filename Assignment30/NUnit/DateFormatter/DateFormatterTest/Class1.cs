using NUnit.Framework;
using DateFormatter;
using System;

namespace DateFormatterTest
{
    [TestFixture]
    public class DateFormatTests
    {
        private DateFormat _dateFormatter;

        [SetUp]
        public void SetUp()
        {
            _dateFormatter = new DateFormat();
        }

        [TestCase("2025-02-22", "22-02-2025")]
        [TestCase("2020-12-31", "31-12-2020")]
        [TestCase("1999-01-01", "01-01-1999")]
        public void FormatDate_ValidDate_ReturnsExpectedFormat(string inputDate, string expectedOutput)
        {
            string result = _dateFormatter.FormatDate(inputDate);
            Assert.That(result, Is.EqualTo(expectedOutput), $"Expected {expectedOutput} but got {result}");
        }

        [TestCase("2025-13-40")] // Invalid month/day
        [TestCase("2025-02-30")] // February 30th is invalid
        [TestCase("abcd-ef-gh")] // Non-numeric input
        public void FormatDate_InvalidDate_ThrowsFormatException(string inputDate)
        {
            var ex = Assert.Throws<FormatException>(() => _dateFormatter.FormatDate(inputDate));
            Assert.That(ex.Message, Is.EqualTo("Invalid date format."), $"Unexpected exception message: {ex.Message}");
        }

        [TestCase("")]
        [TestCase(null)]
        public void FormatDate_EmptyOrNullDate_ThrowsArgumentException(string inputDate)
        {
            var ex = Assert.Throws<ArgumentException>(() => _dateFormatter.FormatDate(inputDate));
            Assert.That(ex.Message, Is.EqualTo("Input date cannot be null or empty."), $"Unexpected exception message: {ex.Message}");
        }
    }
}

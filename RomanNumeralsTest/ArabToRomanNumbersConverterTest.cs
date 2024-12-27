using RomanNumerals;
using NUnit.Framework;

namespace RomanNumeralsTest
{
    public class RomanNumeralsTest
    {
        private RomanToArabNumbersConverter? _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new RomanToArabNumbersConverter();
        }

        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        public void ShouldReturnValueIfNumeralLenghtIsOne(string roman, int expected)
        {
            var result = _converter.ConvertFromRomanToArab(roman);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("III", 3)]
        [TestCase("XX", 20)]
        public void ShouldReturnValueIfNumeralIsMadeOfOnlyOneLetter(string roman, int expected)
        {
            var result = _converter.ConvertFromRomanToArab(roman);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XXVI", 26)]
        public void ShouldSubtractIfLowerValueIsOnTheLeftOfGreaterValue(string roman, int expected)
        {
            var result = _converter.ConvertFromRomanToArab(roman);
            Assert.That(result, Is.EqualTo(expected));
        }
        
        [Test]
        public void ShouldThrowAnExceptionIfTheNumeralIsNotFormallyCorrect()
        {
            var invalidRomanNumeral = "IIII";
            Assert.Throws<ArgumentException>(() => _converter.ConvertFromRomanToArab(invalidRomanNumeral));
        }
    }
}

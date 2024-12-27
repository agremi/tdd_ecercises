using RomanNumerals;
using NUnit.Framework;

namespace RomanNumeralsTest
{
    public class Tests
    {
        private RomanToArabNumbersConverter? _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new RomanToArabNumbersConverter();
        }

        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("X", 10)]
        [TestCase("IX", 9)]
        [TestCase("XI", 11)]
        [TestCase("XII", 12)]
        [TestCase("XIII", 13)]
        public void ShouldConvertRomanNumeralsToArabic(string roman, int expected)
        {
            var result = _converter.ConvertFromRomanToArab(roman);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

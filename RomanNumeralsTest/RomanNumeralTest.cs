using RomanNumerals;

namespace RomanNumeralsTest;

public class RomanNumeralTest
{
    private RomanNumeral _numeral;

    [SetUp]
    public void SetUp()
    {
        _numeral = new RomanNumeral();
    }

    [TestCase("XIIII")]
    [TestCase("XXXX")]
    [TestCase("VVVVL")]
    public void ShouldNotAcceptMoreThanThreeConsecutiveNumeral(string romanNumeral)
    {
        bool result = _numeral.CheckStructuralCorrectness(romanNumeral);
        Assert.That(result, Is.EqualTo(false));
    }

    [TestCase("VV")]
    [TestCase("LL")]
    [TestCase("DD")]
    public void ShouldNotAcceptMoreThanOneConsecutiveV(string romanNumeral){
        bool result = _numeral.CheckStructuralCorrectness("VV");
        Assert.That(result, Is.EqualTo(false));
    }
}


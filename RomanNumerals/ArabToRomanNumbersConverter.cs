namespace RomanNumerals;

public class RomanToArabNumbersConverter
{

    private RomanNumeral _numeral;

    public RomanToArabNumbersConverter()
    {
        _numeral = new RomanNumeral();
    }
    public int ConvertFromRomanToArab(string romanNumeral)
    {
        if(!_numeral.CheckStructuralCorrectness(romanNumeral)){
            throw new ArgumentException("The provided roman numeral is not correct");
        }
        
        var convertedNumeral = romanNumeral.Select(letter => _numeral
       .GetValue(letter)).ToList();

        for (int i = 0; i < convertedNumeral.Count(); i++)
        {
            if (i + 1 < convertedNumeral.Count() && convertedNumeral[i] < convertedNumeral[i + 1])
            {
                convertedNumeral[i] = convertedNumeral[i + 1] - convertedNumeral[i];
                convertedNumeral[i + 1] = 0;
            }
        }

        convertedNumeral = convertedNumeral.Where(val => val != 0).ToList();
        return convertedNumeral.Aggregate((acc, letter) => acc + letter);
    }
}

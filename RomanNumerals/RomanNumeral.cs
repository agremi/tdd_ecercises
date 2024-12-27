using System;

namespace RomanNumerals;

public class RomanNumeral
{
    private Dictionary<char, int> Values = new Dictionary<char, int> {
        {'I', 1},
        {'V',5},
        {'X',10},
        {'L',50},
        {'C',100},
        {'D',500},
        {'M',1000}
    };

    public bool CheckStructuralCorrectness(string romanNumeral)
    {
        return CheckNoMoreThanThreeRepetitions(romanNumeral)
        && CheckNoMoreThanOneConsecutiveNumbersThatStartWithFive(romanNumeral);
    }
    public int GetValue(char romanLetter){
        return Values.FirstOrDefault(letter => letter.Key == romanLetter).Value;
    }
    private bool CheckNoMoreThanThreeRepetitions(string romanNumber)
    {
        var result = true;

        var convertedString = romanNumber.ToCharArray();
        for (int i = 0; i < convertedString.Length; i++)
        {
            if (i + 2 < convertedString.Length && convertedString[i] == convertedString[i + 2])
            {
                result = false;
                break;
            }
        }
        return result;
    }
    private bool CheckNoMoreThanOneConsecutiveNumbersThatStartWithFive(string romanNumber)
    {
        var result = true;
        var charsToCheck = new List<char>() { 'V', 'L', 'D' };
        var convertedString = romanNumber.ToCharArray();
        for (int i = 0; i < convertedString.Length; i++)
        {
            if (charsToCheck.Contains(convertedString[i]) && convertedString[i + 1] == convertedString[i])
            {
                result = false;
                break;
            }
        }
        return result;
    }
}

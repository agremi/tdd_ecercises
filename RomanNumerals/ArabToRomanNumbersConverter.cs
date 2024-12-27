namespace RomanNumerals;

public class RomanToArabNumbersConverter
{
    private Func<char[], Func<int, int, int>> SumOrsubtractSwitch = (expression) =>
    {
        if (expression[0] == 'V' || expression[0] == 'X')
        {
            return (acc, num) => acc + num;
        }
        else
        {
            return (acc, num) => acc - num;
        }
    };

    public int ConvertFromRomanToArab(string number)
    {
        var stringAsCharArray = number.ToCharArray();

        if (!number.Contains('V') && !number.Contains('X'))
        {
            return stringAsCharArray
                    .Select(num => 1)
                    .Aggregate(0, (acc, num) => acc + num);
        }
        else
        {
            var startingPoint = stringAsCharArray.Contains('V') ? 5 : 10;

            return stringAsCharArray
                    .Where(num => num != 'V' && num != 'X')
                    .Select(num => 1)
                    .Aggregate(startingPoint, SumOrsubtractSwitch(stringAsCharArray));
        }
    }
}

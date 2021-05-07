using System.Collections.Generic;

namespace RomanNumeral
{
    public class RomanNumeralConvertor
    {
        private static Dictionary<int, string> _symbols = new Dictionary<int, string>
        {
            {1000,"M" },
            {900,"CM" },
            {500,"D" },
            {400,"CD" },
            {100,"C" },
            {90,"XC" },
            {50,"L" },
            {40,"XL" },
            {10,"X" },
            {9,"IX" },
            {5,"V" },
            {4,"IV" },
            {1,"I" },
        };

        public static string Convert(int number)
        {
            var romanNumber = string.Empty;
            foreach (var symbol in _symbols)
            {
                while (number >= symbol.Key)
                {
                    romanNumber += symbol.Value;
                    number -= symbol.Key;
                }
            }
            return romanNumber;
        }
    }
}
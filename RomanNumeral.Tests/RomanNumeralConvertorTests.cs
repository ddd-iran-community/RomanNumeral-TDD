using FluentAssertions;
using Xunit;

namespace RomanNumeral.Tests
{
    public class RomanNumeralConvertorTests
    {
        [Theory]
        [InlineData(1,"I")]
        [InlineData(2,"II")]
        [InlineData(3,"III")]
        [InlineData(5,"V")]
        [InlineData(10,"X")]
        [InlineData(50,"L")]
        [InlineData(20,"XX")]
        [InlineData(4,"IV")]
        [InlineData(69, "LXIX")]
        [InlineData(691, "DCXCI")]
        [InlineData(1496, "MCDXCVI")]
        [InlineData(2311, "MMCCCXI")]
        public void decimal_should_convert_to_roman_numeral(int number,string symbol)
        {
            var result = RomanNumeralConvertor.Convert(number);
            result.Should().Be(symbol);
        }
    }
}

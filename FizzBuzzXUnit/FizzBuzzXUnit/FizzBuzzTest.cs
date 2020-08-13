using Xunit;
using FB = FizzBuzz.FizzBuzz;

namespace FizzBuzzXUnit
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12, "Fizz")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(15, "FizzBuzz")]

        public void TestCompute(int input, string expected)
        {
            string actual = FB.Compute(input);

            Assert.Equal(expected, actual);
        }
    }
}

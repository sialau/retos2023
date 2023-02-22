using Retos2023._00;

namespace Retos2023.Test
{
    public class Retos00
    {
        private readonly BuzzFizz _buzzFizz;
        public Retos00()
        {
            _buzzFizz = new BuzzFizz();
        }

        [Theory]
        [InlineData(3, "fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "buzz")]
        [InlineData(6, "fizz")]
        [InlineData(15, "fizzbuzz")]
        public void GivenNumberShouldReturnExpected(int input, string expected)
        {
            var result = _buzzFizz.GetLabel(input);

            Assert.Equal(expected, result);
        }
    }
}
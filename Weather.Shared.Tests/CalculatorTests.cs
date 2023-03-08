namespace Weather.Shared.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData("1 + 2 * 3", 7d)]
        [InlineData("2 + 2 * 2", 6d)]
        [InlineData("(1 + 2) * (2 + 3)", 15d)]
        public void Should_Calculate_Successfully(string expression, double expected)
        {
            var result = Calculator.Calculate(expression);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(11d, 7d, 4d)]
        [InlineData(0d, 13d, -13d)]
        [InlineData(123d, 23d, 100d)]
        public void Should_Sub_Successfully(double n1, double n2, double expected)
        {
            var result = Calculator.Sub(n1, n2);

            Assert.Equal(expected, result);
        }
    }
}
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
    }
}
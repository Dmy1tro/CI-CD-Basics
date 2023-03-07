using System.Data;

namespace Weather.Shared
{
    public static class Calculator
    {
        /// <summary>
        /// input => "1 + 3 * 2"
        /// output => 7
        /// </summary>
        public static double Calculate(string expression)
        {
            var dt = new DataTable();
            var result = dt.Compute(expression, string.Empty);

            return Convert.ToDouble(result);
        }

        public static double Sub(double num1, double num2) => num1 - num2;
    }
}
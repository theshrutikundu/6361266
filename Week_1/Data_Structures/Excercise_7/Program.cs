using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double presentValue = 1000.0;
            double rate = 0.05;
            int years = 5;

            Console.WriteLine("--- Recursive Forecast ---");
            double future = Forecast.FutureValue(presentValue, rate, years);
            Console.WriteLine($"Future Value after {years} years: {future:F2}");

            Console.WriteLine("--- Memoized Forecast ---");
            double[] memo = new double[years + 1];
            double futureMemo = Forecast.FutureValueMemo(presentValue, rate, years, memo);
            Console.WriteLine($"Memoized Future Value after {years} years: {futureMemo:F2}");

            Console.WriteLine("\nTime Complexity:");
            Console.WriteLine("- Recursive: O(n)");
            Console.WriteLine("- Optimized (memoized): O(n) with space O(n)");
        }
    }
}

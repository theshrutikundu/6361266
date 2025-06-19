namespace FinancialForecasting
{
    public class Forecast
    {
        public static double FutureValue(double presentValue, double rate, int years)
        {
            if (years == 0)
                return presentValue;

            return (1 + rate) * FutureValue(presentValue, rate, years - 1);
        }

        public static double FutureValueMemo(double presentValue, double rate, int years, double[] memo)
        {
            if (years == 0)
                return presentValue;
            if (memo[years] != 0)
                return memo[years];

            memo[years] = (1 + rate) * FutureValueMemo(presentValue, rate, years - 1, memo);
            return memo[years];
        }
    }
}

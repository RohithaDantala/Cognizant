using System;

class Program
{
    static void Main()
    {
        double currentValue = 10000;
        double growthRate = 0.10;
        int years = 5;

        double futureValue =
            FinancialForecast.PredictFutureValue(currentValue, growthRate, years);

        Console.WriteLine("Future Value: " + futureValue);
    }
}
using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());  //праг
        double firstPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double diff = getDiff(firstPrice, nextPrice);

            bool isSignificantDifference = hasDifference(diff, threshold);

            string message = GetResultMessage(firstPrice, nextPrice, diff, isSignificantDifference);
            Console.WriteLine(message);

            firstPrice = nextPrice;
        }
    }

    private static string GetResultMessage(double firstPrice, double nextPrice, double diff, bool isSignificantDifference)
    {
        string result = "";

        if (diff == 0)
        {
            result = string.Format("NO CHANGE: {0}", firstPrice);
        }
        else if (!isSignificantDifference)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, nextPrice, diff * 100);
        }
        else if (isSignificantDifference && (diff > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, nextPrice, diff * 100);
        }
        else if (isSignificantDifference && (diff < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, nextPrice, diff * 100);
        }

        return result;
    }

    private static bool hasDifference(double diff, double threshold)
    {
        if (Math.Abs(diff) >= threshold)
        {
            return true;
        }

        return false;
    }

    private static double getDiff(double firstPrice, double nextPrice)
    {
        double r = (nextPrice - firstPrice) / firstPrice;
        return r;
    }
}
using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {

        if (span > digits.Length)
        {
            throw new ArgumentException();
        }


        else if (digits.All(char.IsDigit) && span >= 0)
        {
            return Enumerable.Range(0, digits.Length - span + 1)
                .Select(i => digits.Substring(i, span))
                .Max(i => i.ToCharArray().Aggregate(1, (long a, char c) => a * Convert.ToInt64(c.ToString())));
        }

        else
        {
            throw new ArgumentException();
        }
    }
}
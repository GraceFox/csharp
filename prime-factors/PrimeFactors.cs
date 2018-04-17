using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    //having trouble with longs and ints. Not pass last Large Number test
    public static IEnumerable<int> Factors(long number)
    {
        List<int> result = new List<int>();

        while (number % 2 == 0)
        {
            yield return 2;
            number /= 2;
        }

        int factor = 3;
        while (factor * factor <= number)
        {
            if (number % factor == 0)
            {
                yield return factor;
                number /= factor;
            }
            else
            {
                factor += 2;
            }
        }

        if (number != 1)
        {
            yield return (int)number;
        }
    }
}
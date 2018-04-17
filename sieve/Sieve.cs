using System;
using System.Collections.Generic;


public static class Sieve
{
    public static int nextPrime;
    public static IEnumerable<int> Primes(int limit)
    {
        List<int> primes = new List<int>();
        primes.Add(2);
        if (limit >= 3)
        {
            nextPrime = 3;
            while (nextPrime < limit)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
        }

        return primes.ToArray();
    }
}
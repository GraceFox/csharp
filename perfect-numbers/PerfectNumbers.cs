using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        var classificationDetermination = new Classification();

        int sum = 0;

        foreach (var n in Enumerable.Range(1, number - 1))
        {
            if (number % n == 0)
            {
                sum += n;
            }
        }

        if (sum.Equals(number)) classificationDetermination = Classification.Perfect;
        else if (sum < number) classificationDetermination = Classification.Deficient;
        else if (sum > number) classificationDetermination = Classification.Abundant;

        return classificationDetermination;
    }
}

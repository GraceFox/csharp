using System;
using System.Linq;

public static class Hamming
{
    public static int Compute(string firstStrand, string secondStrand)
    {
        var compareStrands = firstStrand.Zip(secondStrand, Tuple.Create)
            .Where(match => match.Item1 != match.Item2)
            .Select(match => match.Item1).ToArray().Length;

        return compareStrands;
    }
}

//http://exercism.io/submissions/033737e862a6478d94b19fd4f94618de
// Learnt about ZIP linq and a little about Tuples. 
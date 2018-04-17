using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int To(IEnumerable<int> multiples, int max)
    {
        var result = Enumerable.Range(1, max - 1)
            .Where(i => multiples.Any(multiple => i % multiple == 0));
        return result.Sum();
    }
}

// notes for self
// at first I did the individual cases of %, then refactored to take multiple input,
// but it has the same problem of multiple modulos being added to the result. GAH
//int result = 0;
//for (int i = 0; i < max; i++)
//{
//        foreach (var multiple in multiples)
//        if (i % multiple == 0)
//            result = result + i;
//}
//return result;
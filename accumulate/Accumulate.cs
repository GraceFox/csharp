using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    // what is this magic yield? https://stackoverflow.com/questions/410026/proper-use-of-yield-return
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (var item in collection)
        {
            yield return func(item);
        }
    }
}
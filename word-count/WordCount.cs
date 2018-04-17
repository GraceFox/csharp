using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public static class WordCount
{
    public static IDictionary<string, int> Countwords(string phrase)
    {
        var result = phrase.Split(new [] {" "}, StringSplitOptions.RemoveEmptyEntries)
            .GroupBy(x => x)
            .Select(group => new
        {
            Word = group.Key,
            Count = group.Count()
        });
        return result;
    }
}
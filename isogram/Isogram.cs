using System;
using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var lettersToCheck = word.ToLower().Where(char.IsLetter).ToList();
        return lettersToCheck.Distinct().Count() == lettersToCheck.Count();
    }
}

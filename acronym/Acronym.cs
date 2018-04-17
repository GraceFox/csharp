using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var firstLetterOfEachWord = "";
        string[] splitString = phrase.Split(' ', '-');
        foreach (string s in splitString)
        {
            firstLetterOfEachWord += s[0];
        }
        return firstLetterOfEachWord.ToUpper();
    }
}
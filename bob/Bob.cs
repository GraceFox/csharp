using System;
using System.Linq;

public static class Bob
{
    public static string Hey(string statement)
    {
        statement = statement.Trim();

        if (statement == string.Empty)
        {
            return "Fine. Be that way!";
        }

        if (statement.Any(char.IsLetter) && !statement.Any(char.IsLower))
        {
            return "Whoa, chill out!";
        }

        if (statement.EndsWith("?"))
        {
            return "Sure.";
        }

        return "Whatever.";
    }
}
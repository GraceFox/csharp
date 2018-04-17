using System;
using System.Linq;
using System.Net.Sockets;
using Xunit.Abstractions;
using System.Collections.Generic;

public static class Pangram
{
    private static string alphabet = "abcdefghijklmnopqrstuvwxyz";

    public static bool IsPangram(string input)
    {
        var lowerCaseInput = input.ToLower();
        return alphabet.All(dictionary => lowerCaseInput.Contains(dictionary));
    }
}
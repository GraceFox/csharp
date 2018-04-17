using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Complement
{
    public static string OfDna(string nucleotide)
    {
        StringBuilder response = new StringBuilder(nucleotide);
 
        response.Replace("G", ".").Replace("C", "G").Replace(".", "C").Replace("A", "U").Replace("T", "A");

        return response.ToString();
    }
}

// Found another elegant solution: http://exercism.io/submissions/25ff9f07a09d4702aecee08365511708
// Try this linq: https://stackoverflow.com/questions/28460231/how-to-swap-characters-in-a-string

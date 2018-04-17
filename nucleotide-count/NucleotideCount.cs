using System;
using System.Collections.Generic;

public class DNA
{
    private readonly Dictionary<char, int> dnaDictionary = new Dictionary<char, int>  
    {
        { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 }
    };


    public DNA(string sequence)
    {
        foreach (var nucleotide in sequence)
        {
            dnaDictionary[nucleotide]++;
        }
    }

    public Dictionary<char, int> NucleotideCounts => dnaDictionary;

    public int Count(char nucleotide)
    {
        if (dnaDictionary.ContainsKey(nucleotide))
        { return dnaDictionary[nucleotide];}
        throw new InvalidNucleotideException();
    }
}

public class InvalidNucleotideException : Exception
{
}

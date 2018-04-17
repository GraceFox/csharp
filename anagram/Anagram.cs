using System;

    //https://www.dotnetperls.com/anagram
    //https://www.codeproject.com/Articles/251749/Really-Simple-Anagram-Solver



public class Anagram
{
    public Anagram(string baseWord)
    {
        var char1 = baseWord.ToCharArray();
        Array.Sort(char1);
    }

    public string[] Anagrams(string[] potentialMatches)
    {
        foreach (var word in potentialMatches)
        {
            word.ToCharArray();
        }

        Array
    }


    // check the matches to see if the length of the words are the same
    //take each letter of the baseword and compare to the potential matches, if they match then BINGO
    //if not then nothing
}
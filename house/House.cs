using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

public static class House
{

    private static readonly string[] Things =
    {
        "house that Jack built",
        "malt",
        "rat",
        "cat",
        "dog",
        "cow with the crumpled horn",
        "maiden all forlorn",
        "man all tattered and torn",
        "priest all shaven and shorn",
        "rooster that crowed in the morn",
        "farmer sowing his corn",
        "horse and the hound and the horn"
    };

    private static readonly string[] Action =
    {
        "lay in",
        "ate",
        "killed",
        "worried",
        "tossed",
        "milked",
        "kissed",
        "married",
        "woke",
        "kept",
        "belonged to",
        ""
    };


    public static string Play()
    {
        for (int i = 0; i < UPPER; i++)
        {
            
        }
        var numberOfVerses = Things.Length;
        return string.Join("\n\n", Enumerable.Range(1, numberOfVerses).Select(Verse));
    }

    //public static string Verse(int number)
    //{
    //    return string.Join("\n", Enumerable.Range(1, number).Reverse().Select(index => Verses(number, index)));
    //}

    //public static string Verses(int start, int end)
    //{
    //    var things = House.Things[end - 1];
    //    var action = House.Action[end - 1];
    //    var ending = end == 1 ? "." : "";

    //    return end == start ? $"This is the {things}{ending}" : $"that {action} the {things}{ending}";
    //}

    StringBuilder _boo = new StringBuilder("This is the that", 50);
    
    _boo.Insert(8, "house");
        ; 



}

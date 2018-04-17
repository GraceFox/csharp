using System;
using System.Collections.Generic;
using System.Linq;

// jEjONES http://exercism.io/submissions/3034b85b5c024221a641b4824a71c424
public static class TwelveDaysSong
{
    private static readonly string[] nth = {
        "zeroth", "first", "second", "third", "fourth", "fifth", "sixth",
        "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth"
    };
    private static readonly string[] gift = {
        "Total Perspective Vortex",
        "a Partridge in a Pear Tree",
        "two Turtle Doves",
        "three French Hens",
        "four Calling Birds",
        "five Gold Rings", 
        "six Geese-a-Laying",
        "seven Swans-a-Swimming",
        "eight Maids-a-Milking",
        "nine Ladies Dancing",
        "ten Lords-a-Leaping",
        "eleven Pipers Piping",
        "twelve Drummers Drumming"
    };

    private static string seriesGift(int verseNumber, int giftNumber)
    {
        return (giftNumber == 1 && verseNumber > 1) ? "and " + gift[1]
            : gift[giftNumber];
    }

    public static string Sing()
    {
        return Verses(1, 12);
    }

    public static string Verse(int verseNumber)
    {
        var giftsDuJour = String.Join(", ", Enumerable.Range(1, verseNumber)
            .Reverse()
            .Select(n => seriesGift(verseNumber, n)));
        return String.Format("On the {0} day of Christmas my true love gave to me, {1}.\n",
            nth[verseNumber], giftsDuJour);
    }

    public static string Verses(int start, int end)
    {
        return string.Join("\n", Enumerable.Range(start, end - start + 1)
                   .Select(Verse)) + "\n";
    }
}
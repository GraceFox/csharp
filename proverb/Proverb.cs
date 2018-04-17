using System;
using System.Linq;

public static class Proverb
{
    private static readonly string [] proverb = {
        "For want of a nail the shoe was lost.",
        "For want of a shoe the horse was lost.",
        "For want of a horse the rider was lost.",
        "For want of a rider the message was lost.",
        "For want of a message the battle was lost.",
        "For want of a battle the kingdom was lost.",
        "And all for the want of a horseshoe nail."};
    public static string Line(int line)
    {
        return proverb[line - 1];
    }

    public static string AllLines()
    {
        return String.Join("\n", proverb);
    }
}
//LouisRBurns deals with the specific items and then build sthe string format http://exercism.io/submissions/90e4e426f9004caaba8b451b16be3b35
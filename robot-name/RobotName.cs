using System;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Serialization;

public class Robot
{
    public static string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string Numbers = "0123456789";

    private static readonly Random random = new Random();
    public string Name { get; private set; } = Namer();

    public static string Namer()
    {
        var charName = new char[2];
        for (var i = 0; i < 2; i++)
        {
            charName[i] = Letters[random.Next(Letters.Length)];
        }

        var intName = new char[3];
        for (var i = 0; i < 3; i++)
        {
            intName[i] = Numbers[random.Next(Numbers.Length)];
        }

        return new string(charName.Concat(intName).ToArray());
    }

    public void Reset()
    {
        Name = Namer();
    }
}


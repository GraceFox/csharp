using System.Text;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var rain = new StringBuilder();

        if (number % 3 == 0) rain.Append("Pling");
        if (number % 5 == 0) rain.Append("Plang");
        if (number % 7 == 0) rain.Append("Plong");
        if (rain.Length < 1) rain.Append(number);

        return rain.ToString();
    }
}

// I ran into the interesting problem of it appending the number only any modulo 7 or multi 
// answers ie. Plong14, as I first had the final check as the default else.
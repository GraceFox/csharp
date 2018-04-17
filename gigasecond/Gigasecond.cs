using System;

public static class Gigasecond
{

    public static DateTime Date(DateTime birthDate)
    {
        return birthDate.AddSeconds(1_000_000_000);
    }
}

//http://exercism.io/submissions/3987a33d3e824e1b918c440e
// http://exercism.io/tracks/csharp/exercises/gigasecond
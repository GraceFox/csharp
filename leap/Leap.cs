using System;
using System.Runtime.InteropServices.ComTypes;
using Xunit.Sdk;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        return (year % 100 == 0) ? (year % 400 == 0) : (year % 4 == 0);
    }

    //Ternary operator
    //Trick here was to work out the logic tree so that it ran in the right order to be able to pass all the tests

    //http://exercism.io/submissions/85a1311a875b40ab8722e3295deb1590
    //http://exercism.io/tracks/csharp/exercises/leap
}
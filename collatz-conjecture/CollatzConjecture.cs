using System;
using System.Diagnostics.Tracing;

public static class CollatzConjecture
{
    // something wrong with the tests when run as a suite they will fail, when run individually they will pass

    public static int Counter = 0;
    public static int GetSteps(int input)
    {
        if (input <= 0)
        {
            throw new ArgumentException();
        }

        while (input > 1)
        {
            Counter++;

            return input % 2 == 0 ? input = input / 2 : input = (input * 3) + 1;
        }
        return Counter;
    }
}

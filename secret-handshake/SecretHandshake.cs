using System;
using System.Collections.Generic;
using System.Linq;

public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        // works for up to 32
        List<string> response = new List<string>();
        var reverse = true;

        if (commandValue >= 16)
        {
            reverse = false;
            commandValue -= 16;
        }

        if (commandValue >= 8)
        {
            response.Add("jump");
            commandValue -= 8;
        }

        if (commandValue >= 4)
        {
            response.Add("close your eyes");
            commandValue -= 4;
        }

        if (commandValue >= 2)
        {
            response.Add("double blink");
            commandValue -= 2;
        }

        if (commandValue == 1)
        {
            response.Add("wink");
        }

        if (reverse)
        {
            response.Reverse();
        }
        return response.ToArray();
    }
}

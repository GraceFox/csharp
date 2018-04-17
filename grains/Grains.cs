﻿using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        return (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        return (ulong) Math.Pow(2, 64) ;
    }
}
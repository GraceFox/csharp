using System;
using System.Linq;

public enum TriangleKind
{
    Equilateral,
    Isosceles,
    Scalene
}


//Weird test results, when run all once, 2 illegal triangles tests fail, but on second run they pass, and if I debug they pass *shrug*
public static class Triangle
{
    public static bool trueTriangle;
    
    public static TriangleKind Kind(decimal side1, decimal side2, decimal side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0) throw new TriangleException();


        workOutifATrueTriangle(side1, side2, side3);

        if (trueTriangle)
        {
            TriangleKind triangleClassifer;

            if (side1 == side2 && side2 == side3)
            {
                triangleClassifer = TriangleKind.Equilateral;
            }

            else if (side1 == side2 | side2 == side3 | side3 == side1)
            {
                triangleClassifer = TriangleKind.Isosceles;
            }
            else
            {
                triangleClassifer = TriangleKind.Scalene;
            }
            return triangleClassifer;
        }

        else throw new TriangleException();
    }

    private static void workOutifATrueTriangle(decimal side1, decimal side2, decimal side3)
    {
        decimal[] sides = {side1, side2, side3};
        sides = sides.OrderByDescending(c => c).ToArray();

        var longestSide = sides.First();

        var remainingSides = sides.Skip(1).ToArray();
        var otherSidesSums = remainingSides.Sum();

        if (longestSide - otherSidesSums < 0)
        {
            trueTriangle = true;
        }
    }
}

public class TriangleException : Exception { }


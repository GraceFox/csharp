using System;
using static Bearing;

public enum Bearing
{
    North,
    East,
    South,
    West
}

public struct Coordinate
{
    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; private set; }
    public int Y { get; set; }
}

public class RobotSimulator
{
    public RobotSimulator(Bearing bearing, Coordinate coordinate)
    {
        Bearing = bearing;
        Coordinate = coordinate;
    }

    public Bearing Bearing { get; set; }

    public Coordinate Coordinate { get; set; }

    public void TurnRight()
    {
         Bearing = Bearing == Bearing.West ? Bearing.North : Bearing + 1;
    }

    public void TurnLeft()
    {
        Bearing = Bearing == Bearing.North ? Bearing.West : Bearing - 1;
    }

    public void Advance()
    {
        switch (Bearing)
        {
            case East:
                Coordinate = new Coordinate(Coordinate.X+1, Coordinate.Y);
                break;
            case North:
                Coordinate = new Coordinate(Coordinate.X, Coordinate.Y+1);
                break;
            case West:
                Coordinate = new Coordinate(Coordinate.X-1, Coordinate.Y);
                break;
            case South:
                Coordinate = new Coordinate(Coordinate.X, Coordinate.Y-1);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void Simulate(string instructions)
    {
        foreach (var i in instructions)
        {
            switch (i)
            {
                case 'R':
                    TurnRight();
                    break;
                case 'L':
                    TurnLeft();
                    break;
                case 'A':
                    Advance();
                    break;
            }
        }
    }
}
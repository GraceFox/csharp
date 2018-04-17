using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}


public static class Queens
{
    public static bool CanAttack(Queen white, Queen black)
    {
        if (white.Column == black.Column && white.Row == black.Row)
        {
            throw new ArgumentException();
        }

        return white.Column == black.Column 
               || white.Row == black.Row
               || IsDiagonal();

        bool IsDiagonal()
        {
            var rowDiff = Math.Abs(white.Row - black.Row);
            var colDiff = Math.Abs(white.Column - black.Column);
            return rowDiff == colDiff;
        }
    }
}
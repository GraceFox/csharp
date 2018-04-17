using System;
using System.Collections.Generic;
using System.Linq;

// Found Thorcain's submission to be very readable http://exercism.io/submissions/8c490ebc44624fa8b107b9fc8c3b3f64
// upperbound reading http://dev.fyicenter.com/dot-NET-Tutorial-for-Beginners/121_Getupperbound_and_getlowerbound_.html

public class SaddlePoints
{
    private readonly int[,] _values;
    private readonly int rows;
    private readonly int cols;

    public SaddlePoints(int[,] values)
    {
        _values = values;
        rows = values.GetUpperBound(0) + 1;
        cols = values.GetUpperBound(1) + 1;
    }

    public IEnumerable<Tuple<int, int>> Calculate()
    {
        for(var r = 0; r < rows; r++)
        {
            for(var c = 0; c < cols; c++)
            {
                var row = Row(r).ToArray();
                var col = Col(c);
                var maxInRow = row.Max();
                var minInCol = col.Min();
                var saddle = row[c];
                if (saddle >= maxInRow && saddle <= minInCol) yield return Tuple.Create(r, c);
            }
        }
    }

    private IEnumerable<int> Row(int r) => Enumerable.Range(0, cols).Select(c => _values[r, c]);
    private IEnumerable<int> Col(int c) => Enumerable.Range(0, rows).Select(r => _values[r, c]);

}
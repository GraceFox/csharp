using System.Linq;

//like the clarity of Tonikaa87's code http://exercism.io/submissions/3a24dcccbd564d93990a433574089950

public class Matrix
{
    private readonly int[][] _matrix;

    public Matrix(string input)
    {
        _matrix = input.Split('\n')
            .Select(line => line.Split(' ')
            .Select(s => int.Parse(s)).ToArray())
            .ToArray();
    }

    public int Rows => _matrix.Length;
    public int Cols => _matrix.First().Length;


    public int[] Row(int row)
    {
        return _matrix[row];
    }

    public int[] Col(int col)
    {
        return _matrix.Select(row => row[col]).ToArray();
    }
}

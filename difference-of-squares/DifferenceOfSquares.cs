public static class Squares
{
    private static int _sum;
    private static int _squareSum;

    public static int SquareOfSums(int max)
    {
        var total = 0;
        for (int i = 0; i <= max; i++)
        {
            total += i;
        }
        _sum = total * total;
        return _sum;
    }

    public static int SumOfSquares(int max)
    {
        var total = 0;
        for (int i = 0; i <= max; i++)
        {
            _squareSum = i * i;
            total = _squareSum += total;
        }
        return _squareSum;

        //var result = Enumerable.Range(1, max - 1) 
        //    (i => i +=(i => i * i));
        //return result.Sum();
    }

    public static int DifferenceOfSquares(int max)
    {
        return SquareOfSums(max) - SumOfSquares(max);
    }
}

//submitted http://exercism.io/submissions/ee6e12f0fcb9405db6ac6b75bf6311c1
//others http://exercism.io/tracks/csharp/exercises/difference-of-squares
// could have used Math.pow  and/or Linq range
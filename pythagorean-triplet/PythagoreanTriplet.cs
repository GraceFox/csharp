using System.Collections.Generic;

public class Triplet
{
    private readonly int _a;
    private readonly int _b;
    private readonly int _c;

    public Triplet(int a, int b, int c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public int Sum()
        => _a + _b + _c;

    public int Product()
        => _a * _b * _c;


    public bool IsPythagorean()
        => _a * _a + _b * _b == _c * _c;

    public static IEnumerable<Triplet> Where(int maxFactor, int minFactor = 1, int? sum = null)
        // note: int? sum = null was previously int sum = 0 which failed with 
        //Expected: Int32[] [60, 480]
        //Actual:   OrderedEnumerable<Int32, Int32>[]  a very curious failure indeed.
    {
        var triplets = new List<Triplet>();

        for (var a = minFactor; a <= maxFactor - 2; a++)
        {
            for (var b = a + 1; b <= maxFactor - 1; b++)
            {
                for (var c = b + 1; c <= maxFactor; c++)
                {
                    var triplet = new Triplet(a, b, c);

                    if (triplet.IsPythagorean()
                        && (sum == null || triplet.Sum() == sum))
                    {
                        triplets.Add(triplet);
                    }
                }
            }
        }

        return triplets;
    }
}

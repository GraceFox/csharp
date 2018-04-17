// from isqrl http://exercism.io/submissions/8f8b5f8866c841799ffee5bc363a5cfd

public class BinarySearch
{
    private  int[] _input;

    public BinarySearch(int[] input)
    {
       _input = input;
    }

    public int Find(int value)
    {
        return Find(value, 0, _input.Length);
    }

    private int Find(int value, int first, int last)
    {

        while (last - first > 0)
        {
            int mid = (first + last) / 2;
            if (_input[mid] > value) last = mid;
            else if (_input[mid] < value) first = mid + 1;
            else return mid;
        }
        return -1;
    }


    ////--- submitted answer
    //int result = Array.BinarySearch(_input, value);
    //if (value != result)
    //{return -1;}
    //return result;
}
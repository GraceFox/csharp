using System;
using System.Collections.Generic;

//this one looks good http://exercism.io/submissions/a2f58be3c5574291a56f850f0b454eb5
//this one looks simple http://exercism.io/submissions/4f6b326215c54497aea3c33e1c216123


class Allergies
{
    List<string> allergyList = new List<string>();

    public Allergies(int result)
    {
        if (result >= 128)
        {
            allergyList.Add("cats");
            result -= 128;
        }

        if (result >= 64)
        {
            allergyList.Add("pollen");
            result -= 64;
        }
        
        if (result >= 32)
        {
            allergyList.Add("chocolate");
            result -= 32;
        }

        if (result >= 16)
        {
            allergyList.Add("tomatoes");
            result -= 16;
        }

        if (result >= 8)
        {
            allergyList.Add("strawberries");
            result -= 8;
        }

        if (result >= 4)
        {
            allergyList.Add("shellfish");
            result -= 4;
        }

        if (result >= 2 && !((result -2) > 1))
        {
            allergyList.Add("peanuts");
            result -= 2;
        }

        if (result >= 1)
        {
            allergyList.Add("eggs");
        }

        allergyList.Reverse();
        foreach (var value in allergyList)
        {
            Console.Write(value + "\n");
        }
    }

    public bool IsAllergicTo(string item)
    {
        return allergyList.Contains(item);
    }

    public List<string> List()
    {
        return allergyList;
    }
}
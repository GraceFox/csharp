using System;
using System.Collections.Generic;

//this one looks simple http://exercism.io/submissions/4f6b326215c54497aea3c33e1c216123

class Allergies
{
    //list for result
    List<string> allergyList = new List<string>();

    [Flags]
    public enum Allergens
    {
        None = 0,
        eggs = 1,
        peanuts = 2,
        shellfish = 4,
        strawberries = 8,
        tomatoes = 16,
        chocolate = 32,
        pollen = 64,
        cats = 128
    }

    public Allergies(int mask)
    {
        foreach (Allergens allergen in Enum.GetValues(typeof(Allergens)))
        {
            if (((int) allergen & mask) != 0)
            {
                allergyList.Add(allergen.ToString());
            }
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
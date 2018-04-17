using System;
using System.Collections.Generic;
using System.Linq;

// attributed to tomikaa87, http://exercism.io/submissions/c84b279fa7db4a78989b39f1a749560e

public class School
{
    public Dictionary<string, int> _roll = new Dictionary<string, int>();

    public void Add(string name, int grade)
    {
        _roll.Add(name, grade);
    }

    public IEnumerable<string> Roster()
    {
        return _roll
            .OrderBy(item => item.Value)
            .ThenBy(item => item.Key)
            .Select(item => item.Key)
            .ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        return _roll
            .Where(item => item.Value == grade)
            .Select(item => item.Key)
            .OrderBy(item => item);
    }
}
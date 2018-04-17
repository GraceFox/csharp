using System;
using System.Collections.Generic;
using System.Linq;

public static class ETL
{
    public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> old)
    {
        var newValue = old
            .SelectMany(i => i.Value.Select(v => new KeyValuePair<string, int>(v.ToLowerInvariant(), i.Key)))
            .OrderBy(item => item.Key)
            .ToDictionary(item => item.Key, item => item.Value);

        return newValue;
    }
}
//https://msdn.microsoft.com/en-us/library/bb549277(v=vs.110).aspx
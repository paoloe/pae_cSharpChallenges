using System;
using System.Linq;

class challenge6{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        string[] merged = names1.Union(names2).ToArray();
        return merged;
    }
}
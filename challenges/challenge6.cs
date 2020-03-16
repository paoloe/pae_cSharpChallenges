using System;
using System.Linq;

class challenge6{
   
   /* 
        Challenge6 - merging two string arrays with no duplicates!
        Again this solution uses the reference System.Linq and uses
        the function Union to do just what is required!
    */
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        string[] merged = names1.Union(names2).ToArray();
        return merged;
    }
}
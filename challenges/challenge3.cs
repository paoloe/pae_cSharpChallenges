using System;
using System.Linq;

namespace pae_csharpChallenges.challenges
{
     /* 
        Challenge 3: Given two string array lists, concatenate the two and remove duplicates!
        
        This challenge is a practice one from test dome! All of the tests can be found
        here https://www.testdome.com/d/c-sharp-interview-questions/18.
      */
    public class challenge3
    {
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        String[] x = names1.Union(names2).ToArray();
        return x;
    }
    
    public static void test()
    {
        string[] names1 = new string[] {"Ava", "Emma", "Olivia"};
        string[] names2 = new string[] {"Olivia", "Sophia", "Emma"};
        Console.WriteLine(string.Join(", ", UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
    }
}
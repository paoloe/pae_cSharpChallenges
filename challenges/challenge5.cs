using System;
using System.Linq;

class challenge5{    
    
    public static double Average(int a, int b)
    {
        /* 
            Using the .Average function with an array works out
            the average of the given array. This is using the library
            System.Linq
         */
        double[] x ={a, b}; 
        double y = x.Average();
        return y;
    }
    
}
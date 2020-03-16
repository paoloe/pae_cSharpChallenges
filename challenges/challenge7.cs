using System;
using System.Collections.Generic;

/* 
    Challenge7 - Implement the two methods TextInput and
    NumericalInput. To add character or numerical values
    to a String. TextInput is for adding non numerical 
    values and NumericalInput must extend TextInput but
    is used for adding new numerical values to the string.
 */

public class TextInput {
    // this is the string value where input is saved
    public string x = "";

    // this method adds a character to string X 
    public void Add(char c){
        x += c;
    }

    // this method returns the value of string X
    public string GetValue(){
        return x;
    }
}
/* 
    NumericInput Extends TextInput
    But handles the numerical input
 */
public class NumericInput : TextInput{
    // saving the value numerical values into a list
    List<int> y;

    /* 
        this method should add only numerical input into the
        list of integers y. 
     */
    public void Add(){

    }

    /* 
        GetValue() - what this method does is it loops through
        each character of the String X, and checks if the value
        is an integer. If it is store it in Y. 

        This way using this method will only return the numerical
        values within String X.
     */
    public List<int> GetValue(){
        foreach (char item in x.ToCharArray())
        {
            var isNumeric = int.TryParse(x, out int n);
            if(isNumeric){
                y.Add(Int32.Parse(x));
            }
        }
        return y;
    }
}

public class challenge7
{
    public static void test(){
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}
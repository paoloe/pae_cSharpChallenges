using System;
using System.Collections.Generic;

public class TextInput {
    public string x = ""; 
    public void Add(char c){
        x += c;
    }

    public string GetValue(){
        return x;
    }
}

public class NumericInput : TextInput{
    List<int> y;
    public void Add(){
        
    }

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
//Problem 10. Unicode characters• Write a program that converts a string to a sequence of C# Unicode character literals.
//• Use format strings.
//Example:
//input
//output
//Hi! \u0048\u0069\u0021 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        StringBuilder output = new StringBuilder();

        // https://msdn.microsoft.com/en-us/library/hdekwk0b(v=vs.110).aspx

        foreach (var item in text)
        {
            output.AppendFormat("\\u{0:X4}", (int)item);
        }
        Console.WriteLine(output.ToString());

        //https://msdn.microsoft.com/en-us/library/system.string.format(v=vs.110).aspx

        string result = string.Empty;
        foreach (var item in text)
        {
            result += String.Format("\\u{0:X4}", (int)item);
        }
                
        Console.WriteLine(result);
        
    }
}

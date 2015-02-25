//Problem 1. Strings in C#. 
//• Describe the strings in C#.
//• What is typical for the string data type?
//• Describe the most important methods of the String class.

using System;

class StringsInCSharp
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.Strings are immutable sequence of charracters. Each character is a Unicode symbol.");
        Console.WriteLine();
        Console.WriteLine("2.String objects contain an immutable (read-only) sequence of characters");
        Console.WriteLine();
        Console.WriteLine("3.Most important metods are Compare(str1, str2), IndexOf(str), LastIndexOf(str), Substring(startIndex, length), Replace(oldStr, newStr), Remove(startIndex, length), ToLower(), ToUpper(), Trim()");
        Console.WriteLine();
    }
}

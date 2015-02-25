//Problem 23. Series of letters
//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:
//input	output
//aaaaabbbbbcdddeeeedssaa	abcdedsa
//aaaaaaaaaaaaaaaaaaabbbbbbbbbaaaaaaaaa

using System;
using System.Collections.Generic;
using System.Text;


class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Please, enter text");
        string text = Console.ReadLine();
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            if (i==0)
            {
                output.Append(text[0]);
            }
            else if (text[i-1]!=text[i])
            {
                output.Append(text[i]);
            }
        }
        Console.WriteLine(output);
    }
}

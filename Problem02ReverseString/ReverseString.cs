//Problem 2. Reverse string• Write a program that reads a string, reverses it and prints the result at the console.
//Example:
//input
//output
//sample elpmas 

using System;
using System.Text;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter some text");
        string input = Console.ReadLine();
        StringBuilder output = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            output.Append(input[i]);
        }
        Console.WriteLine(output);
    }
}

//Problem 3. Correct brackets• Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression:  ((a+b)/5-d) . Example of incorrect expression:  )(a+b)) .

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter some text");
        string text = Console.ReadLine();
        if (CheckBrackets(text))
        {
            Console.WriteLine("Correct expresion");
        }
        else
        {
            Console.WriteLine("Incorrect expression");
        }

        //int count1 = text.Split('(').Length - 1;
        //int count2 = text.Split(')').Length - 1;
        //if ((count1 % 2 == 1) || (count2 % 2 == 1))
        //{
        //    Console.WriteLine("Incorrect expression");
        //}
        //else
        //{
        //    Console.WriteLine("Correct expresion");
        //}
    }
    static bool CheckBrackets(string text)
    {
        int counter = 0;
        foreach (char item in text)
        {
            
            if (item == '(')
            {
                ++counter;
            }
            else if (item == ')')
            {
                --counter;
            }
            if (counter < 0)
            {
                return false;
            }
        }
        return true;
        
    }
}
//Problem 21. Letters count
//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Text;

class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Please, enter text");
        string text = Console.ReadLine();   // Write a program that reads a string from the console and prints
               
        List<string> letters = new List<string>();
        List<string> usedLetter = new List<string>();
        
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (text[i] == text[j] && char.IsLetter(text[i]))
                {
                    letters.Add(text[j].ToString());
                }
            }

            if (!usedLetter.Contains(text[i].ToString()) && char.IsLetter(text[i]))
            {
                Console.WriteLine("{0} found {1} times ", text[i], letters.Count); 
            }
            usedLetter.Add(text[i].ToString());
            letters.Clear();
        }
    }
}

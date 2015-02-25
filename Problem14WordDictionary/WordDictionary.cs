//Problem 14. Word dictionary
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:
//input	output
//.NET	platform for applications from Microsoft
//CLR	managed execution environment for .NET
//namespace	hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class WordDictionary
{
    static void Main()
    {
        string[] dictionary = { ".NET-platform for applications from Microsoft", 
                                  "CLR-managed execution environment for .NET",
                                  "namespace-hierarchical organization of classes",
                                     "!-exclamation mark",
                                    "?-question mark"};

        Console.WriteLine("Please,enter a word");
        string input = Console.ReadLine();
        bool check = true;
        int indexLenght = 0;
        for (int i = 0; i < dictionary.Length; i++)
        {
           indexLenght = dictionary[i].Substring(0, dictionary[i].IndexOf('-')).Length;
           if (String.Compare(input, dictionary[i].Substring(0,indexLenght), true) == 0)
            {
                Console.WriteLine(dictionary[i]);
                check = true;
                break;
            }
            else
            {
                check = false;
            }
        }
        if (check == false)
        {
            Console.WriteLine("No translation");
        } 
     }
}


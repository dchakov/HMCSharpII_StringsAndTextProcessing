//Problem 13. Reverse sentence• Write a program that reverses the words in given sentence.
//Example:
//input
//output
// C# is not C++, not PHP and not Delphi!   Delphi not and PHP, not C++ not is C#!  

using System;
using System.Collections.Generic;
using System.Text;


class ReverseSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string[] words = text.Split(new char[] { ' ', ',', '!', '.', '?', ':', '-', '/', ';' }, StringSplitOptions.RemoveEmptyEntries);
        char[] symbols = new char[] { ' ', ',', '!', '.', '?', ':', '-', '/', ';' };

        List<char> charactersToAdd = new List<char>();
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < symbols.Length; j++)
            {
                if ((char)text[i] == symbols[j])
                {
                    charactersToAdd.Add(symbols[j]);
                }
            }
        }
        Array.Reverse(words);

        Queue<string> que = new Queue<string>();
        for (int i = 0; i < words.Length; i++)
        {
            que.Enqueue(words[i]);
        }

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < charactersToAdd.Count; i++)
        {

            if (((i - 1) >= 0) && (char)charactersToAdd[i - 1] == ',')
            {
                output.Append(charactersToAdd[i]);
                continue;
            }
            output.Append(que.Dequeue());
            output.Append(charactersToAdd[i]);

        }

        Console.WriteLine(text);
        Console.WriteLine(output.ToString());
    }
}
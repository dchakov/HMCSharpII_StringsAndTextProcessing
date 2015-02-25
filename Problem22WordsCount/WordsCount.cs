//Problem 22. Words count
//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text;


class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Please, enter text"); // Write a program that reads a string reads the console and program all different words in program string along with information how many times each word is found
        string text = Console.ReadLine();
        string[] textWords = text.Split(new char[] { ' ', ',', '!', '.', '?', ':', '-', '/', ';' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> words = new List<string>();
        List<string> usedWords = new List<string>();

        for (int i = 0; i < textWords.Length; i++)
        {
            for (int j = 0; j < textWords.Length; j++)
            {
                if (string.Compare(textWords[i],textWords[j],false)==0 && textWords[j].Length>1)
                {
                    words.Add(textWords[j].ToString());
                }
            }

            if (!usedWords.Contains(textWords[i].ToString()) && textWords[i].Length > 1)
            {
                Console.WriteLine("{0} ==> {1} times ", textWords[i], words.Count);
            }
            usedWords.Add(textWords[i].ToString());
            words.Clear();
        }
    }
}
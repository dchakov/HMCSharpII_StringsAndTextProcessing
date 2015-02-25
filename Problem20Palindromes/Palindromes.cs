//Problem 20. Palindromes• Write a program that extracts from a given text all palindromes, e.g.  ABBA ,  lamal ,  exe .
//ABBA ,adf,weessfr,  lamal,rtye sew exe .
// Palindromes are very interesting words. Examples for palindromes are ABBA, lamal, exe, rotor. These words can be read the same way in either direction. Other examples -> level, racecar, deed, civic, nun, pop, eye, madam

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class Palindromes
{
    public static string WordsReverse(string currentWord)
    {
        StringBuilder output = new StringBuilder();
        for (int i = currentWord.Length - 1; i >= 0; i--)
        {
            output.Append(currentWord[i]);
        }
        return output.ToString();
    }
    static void Main()
    {
        Console.WriteLine("Enter text");

        string text = Console.ReadLine();
        string[] textWords = text.Split(new char[] { ' ', ',', '!', '.', '?', ':', '-', '/', ';' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> wordsResult = new List<string>();
       
        for (int i = 0; i < textWords.Length; i++)
        {
            if ((string.Compare(textWords[i], WordsReverse(textWords[i]), true) == 0) && textWords[i].Length != 1)
            {
                wordsResult.Add(textWords[i]);
            }
        }
        foreach (var item in wordsResult)
        {
            Console.WriteLine(item);
        }
    }

    
}

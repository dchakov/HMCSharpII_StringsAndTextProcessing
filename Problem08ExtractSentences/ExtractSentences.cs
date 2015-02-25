//Problem 8. Extract sentences• Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by  .  and the words – by non-letter symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractSentences
{
    static void Main(string[] args)
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine(text);
        Console.WriteLine("Enter word");
        string word = Console.ReadLine();
        Console.WriteLine(Extraction(text,word));
    }
    private static string Extraction(string text , string givenWord)
    {
        string word = " " + givenWord + " ";
        StringBuilder output = new StringBuilder();
        string[] sentence = text.Split('.');
        foreach (var item in sentence)
        {
            if (item.IndexOf(word) > 0)
            {
                output.Append(item);
            }

        }
        return output.ToString();
    }

}

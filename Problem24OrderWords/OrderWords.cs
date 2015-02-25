//Problem 24. Order words
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Text;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Please, enter words separated by space"); // Pamporovo Bansko Snowboard Baiko vladko simeon reogram 
        string text = Console.ReadLine();
        string[] listWords = text.Split(new char [] {' ',','},StringSplitOptions.RemoveEmptyEntries);

        //Array.Sort(listWords);     
   
        for (int i = 0; i < listWords.Length; i++)
        {
            string currentFirst = string.Empty;
            for (int j = i+1; j < listWords.Length; j++)
            {
                if (string.Compare(listWords[j],listWords[i])<0)
                {
                    currentFirst = listWords[j];
                    listWords[j] = listWords[i];
                    listWords[i] = currentFirst;
                }
                
            }
        }
        foreach (var item in listWords)
        {
            Console.WriteLine(item);
        }
    }
}

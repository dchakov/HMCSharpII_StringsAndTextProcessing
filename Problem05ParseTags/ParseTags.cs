//Problem 5. Parse tags• You are given a text. Write a program that changes the text in all regions surrounded by the tags  <upcase>  and  </upcase>  to upper-case.
//• The tags cannot be nested.
//Example: We are living in a  <upcase> yellow submarine </upcase> . We don't have  <upcase> anything </upcase>  else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ParseTags
{
    static void Main()
    {
        string input = "We are living in a  <upcase> yellow submarine </upcase> . We don't have  <upcase> anything </upcase>  else.";

        string text1 = input.Replace(" <upcase> ","<");
        string text2 = text1.Replace(" </upcase>" , ">");
        
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < text2.Length; i++)
        {
            if (text2[i] != '<')
            {
                output.Append(text2[i]);
            }
            else
            {
                i++;
                while (text2[i] !='>')
                {
                    output.Append(text2[i].ToString().ToUpper());
                    i++;
                }
            }
        }
        Console.WriteLine(output.ToString());
    }
}

//Problem 18. Extract e-mails
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
//http://www.codeproject.com/Articles/4583/Extracting-EMail-Addresses-From-a-Document-or-Strihttp://www.zytrax.com/tech/web/regex.htm#experiment
//http://www.cphpvb.net/java/4199-regular-expressions/
//http://www.regexlib.com/Search.aspx?k=email&c=1&m=-1&ps=20

// Please assin@any.stup.co.uk contact us baiko_at@hotmail.com  or by email at exampQle@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEMails
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string input = Console.ReadLine();
        string pattern = @"(\w+)@([a-zA-Z0-9_\-\.]+)\.[a-zA-Z]{2,3}";

        Console.WriteLine();
        MatchCollection matches = Regex.Matches(input,pattern);
        for (int i = 0; i < matches.Count; i++)
        {
            Console.WriteLine(matches[i]);
        }
        if (matches.Count == 0)
        {
            Console.WriteLine("No matches");
        }
    }
}

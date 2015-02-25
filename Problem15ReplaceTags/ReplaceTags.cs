//Problem 15. Replace tags
//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//Example:
//input	output
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Enter HTML document");
        string textHTML = Console.ReadLine();
        string output = string.Empty;
        int counter = 0;
        while (textHTML.IndexOf("<a href=\"", counter) > 0)
        {
            output = textHTML.Replace("<a href=\"", "[URL=");
            counter++;
        }
        counter = 0;
        while (output.IndexOf("\">", counter) > 0)
        {
            output = output.Replace("\">", "]");
            counter++;
        }
        counter = 0;
        while (output.IndexOf("</a>", counter) > 0)
        {
            output = output.Replace("</a>", "[/URL]");
            counter++;
        }
        Console.WriteLine(output);
    }
}

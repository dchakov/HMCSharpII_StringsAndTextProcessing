//Problem 25. Extract text from HTML
//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:
//<html><head><title>News</title></head><body><p><a href="http://academy.telerik.com">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>
//Output:
//Title: News
//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.

using System;
using System.Collections.Generic;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        //Console.WriteLine("Please, enter number of rows of  HTML file");
        //int numberOfRows = int.Parse(Console.ReadLine());
        //Console.WriteLine("Please, enter {0} rows",numberOfRows);
        //StringBuilder htmlText = new StringBuilder();

        //for (int i = 0; i < numberOfRows; i++)
        //{
        //    string current = Console.ReadLine();
        //    htmlText.Append(current);
        //    current = string.Empty;
        //}
        
        string htmlText = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

        int indexStart = htmlText.IndexOf("<title>");
        int indexEnd = htmlText.IndexOf("</title>");
        string titleHtml =htmlText.Substring(indexStart+7,indexEnd-indexStart-7);

        Console.WriteLine("Title: {0} ",titleHtml);

        int indexStartBody = htmlText.IndexOf("<body><p>");
        int indexEndBody = htmlText.IndexOf("</p></body>");
        string bodyText = htmlText.Substring(indexStartBody+9, indexEndBody-indexStartBody-9);

        
        StringBuilder result = new StringBuilder();
        bool inTag = false;
        for (int i = 0; i < bodyText.Length; i++)
        {
            if (inTag == true)
            {
                if (bodyText[i] == '>')
                {
                    inTag = false;
                    result.Append(" ");
                }
            }
            else
            {
                if (bodyText[i] == '<')
                {
                    inTag = true;
                    
                }
                else
                {
                    result.Append(bodyText[i]);
                }
            }
        }

        Console.WriteLine("Text: {0}",result.ToString());
       

    }
}

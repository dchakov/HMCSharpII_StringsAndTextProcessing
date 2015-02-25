//Problem 12. Parse URL• Write a program that parses an URL address given in the format:  [protocol]://[server]/[resource]  and extracts from it the  [protocol] ,  [server]  and  [resource]  elements.
//Example: 
//URL
//Information
// http://telerikacademy.com/Courses/Courses/Details/212 
// [protocol] =  http  
// [server] =  telerikacademy.com  
// [resource] =  /Courses/Courses/Details/212   

using System;
using System.Text;
class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212 ";

        Console.WriteLine(url);
        string protocol = url.Substring(0, url.IndexOf(':'));
        int indexDot = url.IndexOf(':');
        int indexSingle = url.IndexOf('/', indexDot + 3);
        string server = url.Substring(indexDot + 3, url.Length - indexDot - 3-(url.Length-indexSingle));
        string resource = url.Substring(indexSingle);

        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}",resource);

    }

}
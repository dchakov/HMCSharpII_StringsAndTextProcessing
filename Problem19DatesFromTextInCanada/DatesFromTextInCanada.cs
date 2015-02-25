//Problem 19. Dates from text in Canada
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

//I was born at 01.10.1974. My brother 34.13.9999 was born at 3.12.1969. In 5/1993 I graduated 33.12.1965 my high 03.12.1964 school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).

using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

class DatesFromTextInCanada
{
    static void Main()
    {
        Console.WriteLine("Enter text with dates");
        string input = Console.ReadLine();
        string patern = @"([0-9]){1,2}\.([0-9]){1,2}\.([0-9]+){4}";

        MatchCollection result = Regex.Matches(input, patern);
        
        for (int i = 0; i < result.Count; i++)
        {
            DateTime date;
            if (DateTime.TryParse(result[i].ToString(),out date))
            {
                DateTime current = DateTime.Parse(result[i].ToString());
                Console.WriteLine(current.ToString(CultureInfo.CreateSpecificCulture("en-CA")));
            }
            
        }
        
        
    }
}

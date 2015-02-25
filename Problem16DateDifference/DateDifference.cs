//Problem 16. Date difference
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;
using System.Threading;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
        Console.WriteLine("Enter first date  dd.mm.yyyy");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter second date  dd.mm.yyyy");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        
        Console.WriteLine("Distance: {0:%d} days",secondDate-firstDate);

        
    }
}

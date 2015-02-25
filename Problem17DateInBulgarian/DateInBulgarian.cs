//Problem 17. Date in Bulgarian
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes
//(in the same format) along with the day of week in Bulgarian.

// 23.02.2015 11:44:35
// 27.02.2015 18:23:23

using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;


class DateInBulgarian
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
        Console.WriteLine("Enter date day.month.year hour:minute:second");
        DateTime input = DateTime.Parse(Console.ReadLine());
        Console.WriteLine();
        input = input.AddHours(6);
        input = input.AddMinutes(30);
        CultureInfo culture = new CultureInfo("bg-BG");
        Console.WriteLine("{0} {1}", input, culture.DateTimeFormat.GetDayName(input.DayOfWeek));
        
    }
}

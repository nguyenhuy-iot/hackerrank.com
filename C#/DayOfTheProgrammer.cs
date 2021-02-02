using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {
    /*
    Marie invented a Time Machine and wants to test it by time-traveling to visit Russia on the Day of the Programmer
    (the 256th day of the year) during a year in the inclusive range from 1700 to 2700.
    From 1700 to 1917, Russia's official calendar was the Julian calendar;
    since 1919 they used the Gregorian calendar system. The transition from the Julian to Gregorian calendar system occurred in 1918,
    when the next day after January 31st was February 14th. This means that in 1918,
    February 14th was the 32nd day of the year in Russia.    
    */

    // Complete the dayOfProgrammer function below.
    static string dayOfProgrammer(int year) {
        bool leap = false;
        DateTime day = new DateTime(year,9,13);  //leap years: 13.9 ,other years: 12.9             
        if (year < 1918)
        {
            // leap years: Divisible by 4.
            leap = year % 4 == 0;               
        }
        else if (year > 1918)
        {
            // leap years: Divisible by 400 or Divisible by 4 and not divisible by 100.
            leap = year % 400 == 0 ||
                (year % 4== 0 && year % 100 != 0);  
        }
        else
        {
            //After 31.01.1818, it is 14.02.1818, instead of 01.02.1818 as usual
            leap = false;
            day = day.AddDays(13); 
        }
        day = leap ? day.AddDays(-1) : day;
        return(day.ToString("dd.MM.yyyy"));
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
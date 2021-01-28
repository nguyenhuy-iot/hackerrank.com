using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution {

    /// <summary>
        /// It should return a new string representing the input time in 24 hour format.
        /// </summary>
        /// <param name="s">string s: a time in  hour format</param>
        /// <returns>string: the time in  hour format</returns>
        static string timeConversion(string s)
        {            
            string T_24h = "";
            string[] numbers = Regex.Split(s, @"\D+");

            if (s.IndexOf('P') > 0)
            {
                if (numbers[0] == "12") //12:00:00PM
                {
                    T_24h = numbers[0];
                }
                else
                {
                    T_24h = (int.Parse(numbers[0]) + 12).ToString();
                }

            }
            else
            {
                if (numbers[0] == "12") //12:00:00AM
                {
                    T_24h = "00";
                }
                else
                {
                    T_24h = numbers[0];
                }
            }
            T_24h += ':' + numbers[1] + ':' + numbers[2];

            return T_24h;
        }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}

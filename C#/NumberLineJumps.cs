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
    Input Format

    A single line of four space-separated integers denoting the respective values of , , , and .

    Constraints

    Output Format

    Print YES if they can land on the same location at the same time; otherwise, print NO.

    Note: The two kangaroos must land at the same location after making the same number of jumps.
    */

    // Complete the kangaroo function below.
    static string kangaroo(int x1, int v1, int x2, int v2) {
        int Distance = Math.Abs(x2 - x1);
        int Jumps = 1;
        while (true)
        {
            if (x1 + v1 * Jumps == x2 + v2 * Jumps) 
            {
                return("YES");
                //break;
            }
            //Math.Abs((x2 + v2 * Jumps) - (x2 + v2 * Jumps)) > Distance            
            if (Math.Abs((x2 + v2 * Jumps) - (x1 + v1 * Jumps)) >= Distance)
            {
                return("NO");
                //break;
            }
            Jumps++;
        }


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

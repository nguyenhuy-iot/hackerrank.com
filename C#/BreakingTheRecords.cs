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

    The first line contains an integer , the number of games.
    The second line contains  space-separated integers describing the respective values of .

    Constraints

    Output Format

    Print two space-seperated integers describing the respective numbers of times the best (highest) score increased and the worst (lowest) score decreased.
    
    */

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores) {
        int best = 0, worst = 0;
        int min =scores[0], max=min;
        foreach(var item in scores)
        {
            if (item < min)
            {
                min = item;
                worst++;
            }
            if (item > max)
            {
                max = item;
                best++;
            }
        }
        int[] result={best,worst};
        return result;


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
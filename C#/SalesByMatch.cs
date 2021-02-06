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

class Solution
{
    /*
    There is a large pile of socks that must be paired by color.
    Given an array of integers representing the color of each sock,
    determine how many pairs of socks with matching colors there are.
    */

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        int result = 0;
        for (int color = 1; color <= 100; color++)
        {
            int ColorPair = Array.FindAll(ar, x => x == color).Length / 2;
            result += ColorPair;
        }
        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
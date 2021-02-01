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
    Given an array of bird sightings where every element represents a bird type id,
    determine the id of the most frequently sighted type.
    If more than 1 type has been spotted that maximum amount, return the smallest of their ids.
    */

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) {
        arr.Sort();
        int result = 0, frequency = 0, i = 0;
        while (i<arr.Count)
        {
            var f = arr.FindAll(s => s.Equals(arr[i])).Count;
            if (f > frequency)
            {
                result = arr[i];
                frequency = f;                
            }                        
            i += frequency;            
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
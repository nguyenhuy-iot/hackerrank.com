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
    When a contiguous block of text is selected in a PDF viewer, 
    the selection is highlighted with a blue rectangle. In this PDF viewer, 
    each word is highlighted independently.
    determine the area of the rectangle highlight in mm2 assuming all letters are 1mm wide.
    */

    // Complete the designerPdfViewer function below.
    static int designerPdfViewer(int[] h, string word) {
        string[] W = word.Split(' ');
        int Sum_Area = 0;
        foreach(var item in W)
        {
            int tallest = 0;
            foreach(var c in item)
            {
                int index = Convert.ToInt32(c)-97;
                tallest = Math.Max(tallest, h[index]);
            }
            Sum_Area += tallest * item.Length;
        }
        return Sum_Area;


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
        ;
        string word = Console.ReadLine();

        int result = designerPdfViewer(h, word);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
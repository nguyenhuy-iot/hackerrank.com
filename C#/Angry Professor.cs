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
	A Discrete Mathematics professor has a class of students. 
	Frustrated with their lack of discipline, 
	the professor decides to cancel class if fewer than some number of students are present when class starts. 
	Arrival times go from on time (time<=0) to arrived late (time>0).
	*/

    // Complete the angryProfessor function below.
    static string angryProfessor(int k, int[] a) {
        int students =0; // on time
        foreach(var i in  a)
        {
            if(i<=0)
            {
                students++;
                if(students>=k)
                {
                    return "NO";
                }
            }
        }
        return "YES";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            string result = angryProfessor(k, a);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
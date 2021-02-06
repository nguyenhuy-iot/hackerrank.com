using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     A person wants to determine the most expensive computer keyboard and USB drive that can be purchased with a give budget. 
     Given price lists for keyboards and USB drives and a budget, find the cost to buy them. 
     If it is not possible to buy both items, return -1.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b) {
        int MaxSum = -1;
        Array.Sort(keyboards);
        Array.Reverse(keyboards);
        Array.Sort(drives);
        Array.Reverse(drives);

        foreach(int key in keyboards)
        {
            if (key >= b) { continue; }
            foreach( int dri in drives)
            {
                int cost = key + dri;
                if (b >= cost)
                {
                    if (cost > MaxSum)
                    {
                        MaxSum = cost;
                    }
                    Console.WriteLine($"key: {key} ; dri: {dri} ; sost: {cost}");
                    break;
                }
            }
        }
        return MaxSum;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
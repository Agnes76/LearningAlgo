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


namespace LearningAlgo
{
    public class PlusMinus
    {
        //        Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.Print the decimal value of each fraction on a new line with  places after the decimal.

        //Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.

        //Example
        // arr = {1, 1, 0, -1, -1};
        //There are n = 5 elements, two positive, two negative and one zero.Their ratios are 2/5 = 0.400000,2/5 = 0.400000 and 1/5 = 0.200000.Results are printed as:

        //0.400000
        //0.400000
        //0.200000
        //Function Description

        //Complete the plusMinus function in the editor below.

        //plusMinus has the following parameter(s) :

        // *int arr[n]: an array of integers
        //Print
        //Print the ratios of positive, negative and zero values in the array.Each value should be printed on a separate line with digits after the decimal. The function should not return a value.

        //Input Format

        //The first line contains an integer, , the size of the array.
        //The second line contains  space-separated integers that describe .

        //Constraints
        // 0 < n <= 100
        // -100 < arr[i] <= 100


        //Output Format

        //Print the following  lines, each to  decimals:

        //1. proportion of positive values
        //2. proportion of negative values
        //3. proportion of zeros
        //Sample Input

        //STDIN           Function
        //-----           --------
        //6               arr[] size n = 6
        //- 4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
        //Sample Output

        //0.500000
        //0.333333
        //0.166667
        //Explanation

        //There are positive numbers, negative numbers, and zero in the array.
        //The proportions of occurrence are positive:3/6=0.500000 , negative:2/6=0.333333  and zeros:1/6=0.166667 .

        public static void plusMinus(List<int> arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            double total = arr.Count;

            // for(int i = 0; i < arr.Count; i++)
            // {
            //    if(arr[i] > 0) {
            //        positive++;
            //    }
            //    if(arr[i] < 0){
            //        negative++;
            //    }
            //    if(arr[i] == 0){
            //        zero++;
            //    }
            // }

            foreach (var element in arr)
            {
                if (element > 0)
                {
                    positive++;
                }
                if (element < 0)
                {
                    negative++;
                }
                if (element == 0)
                {
                    zero++;
                }
            }

            Console.WriteLine(string.Format("{0:N6}", positive / total));
            Console.WriteLine(string.Format("{0:N6}", negative / total));
            Console.WriteLine(string.Format("{0:N6}", zero / total));

        }
         static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            PlusMinus.plusMinus(arr);
        }
    }
        
}


﻿using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (arr.Length > 1)
            {
                int[] condensed = new int[arr.Length - 1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int firstElement = arr[i];
                    int secondElement = arr[i + 1];
                    int currentSum = firstElement + secondElement;
                    condensed[i] = currentSum;

                }
                arr = condensed;
            }
            Console.WriteLine(arr[0]);
        }
    }
}

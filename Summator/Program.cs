﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6, });
            if (sum == 21)
            {
                Console.WriteLine("Test Pass");
            }
            else
            {
                Console.WriteLine("Test Fail");
            }

            int average = Summator.Average(new int[] { 5, 10, 15 });
            if (average == 10)
            {
                Console.WriteLine("Test Pass");
            }
            else
            {
                Console.WriteLine("Test Fail");
            }

        }
    }
}
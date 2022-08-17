using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */            
            var sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    evens.Add(num);
                else
                    odds.Add(num);
                sum += num;
            }
            Console.WriteLine($"{sum} is the sum of all numbers under ten");
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            var evenSum = 0;
            var oddSum = 0;
            for (int i = 0; i < (evens.Count); i++)
            {
                if (evens[i] % 3 == 0)
                    Console.WriteLine($"{evens[i]} is an even number thats also divisable by 3!");
                else Console.WriteLine($"{evens[i]} is an even number! ( not also divisable by 3 :( )");
                evenSum += evens[i];
            }
            Console.WriteLine($"{evenSum} is the sum of all even numbers under 10 (incl 10)");
            for (int i = 0; i < (odds.Count); i++)
            {
                if (odds[i] % 3 == 0)
                    Console.WriteLine($"{odds[i]} is an odd number thats also divisable by 3!");
                else Console.WriteLine($"{odds[i]} is an odd number! ( not also divisable by 3 :( )");
                oddSum += odds[i];
            }
            Console.WriteLine($"{oddSum} is the sum of all even numbers under 10");
        }
    }
}

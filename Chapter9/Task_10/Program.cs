﻿using System;

namespace Task_10
{
    class Program
    {
        static double Factorial(double number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("{0}! = {1}", i, Factorial(i));
            }
            Console.WriteLine();
        }
    }
}
/* 10. Напишете програма, която пресмята и отпечатва n! за всяко n в
интервала [1…100].*/

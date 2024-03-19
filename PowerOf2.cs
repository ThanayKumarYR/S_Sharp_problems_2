﻿using System;

namespace CSharp_problems_2
{
    class PowerOf2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Power of 2 !");
            Console.Write("Enter 0 number between 0 and 30 = ");
            int exponent = int.Parse(Console.ReadLine());

            if (0 <= exponent && exponent < 31)
            { 
                for (int i = 0;i<=exponent;i++)
                    Console.WriteLine($"2 power {i} = {Math.Pow(2,i)}");
            }
            else
            {
                Console.WriteLine("Enter the number between 0 and 30");
            }
        }
    }
}

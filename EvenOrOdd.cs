﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number = ");
            int number = int.Parse(Console.ReadLine());

            if (number%2 == 0)
            {
                Console.WriteLine($"{number} is even !");
            }
            else 
            {
                Console.WriteLine($"{number} is odd !");
            }
        }
    }
}

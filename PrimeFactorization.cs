using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class PrimeFactorization
    {
        public static bool isPrime(int num)
        { 
            for (int i = 2;i <= Math.Sqrt(num);i++)
            { 
                if (num % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Prime Factorization !");

            Console.Write("Enter the number = ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (isPrime(i)) Console.Write($"{i} ");
                }
            }

            Console.WriteLine("\n Thank you !");
        }
    }
}

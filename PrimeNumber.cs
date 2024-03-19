using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0) 
                {
                    Console.WriteLine($"{number} is not a prime number !");
                    return;
                }
            }
            Console.WriteLine($"{number} not a prime number !");
        }
    }
}

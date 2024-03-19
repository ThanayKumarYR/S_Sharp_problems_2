using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class PerfectNumber
    {
        static void Main(string[] args)
        {
            int summ = 0;
            Console.Write("Enter the number = ");
            int number = int.Parse(Console.ReadLine());


            for (int i = 1; i < number; i++)
            { 
                if(number % i == 0)  summ += i;
            }

            if (number == summ) Console.WriteLine($"{number} is perfect number");
            else Console.WriteLine($"{number} is not perfect number");
        }
    }
}

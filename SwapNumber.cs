using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class SwapNumber
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the first number = ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number = ");
            int second = int.Parse(Console.ReadLine());

            Console.Write($"Swaping of first number = {first} and second number = {second} to ");

            first = first + second;
            second = first - second;
            first = first - second;

            Console.Write($"first number = {first} and second number = {second}.\n");

        }
    }
}

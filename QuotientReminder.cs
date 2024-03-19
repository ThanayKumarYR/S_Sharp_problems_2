using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class QuotientReminder
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the divident or 1st number = ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the divident or 2nd number = ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} / {secondNumber} -> Quotient = {firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} -> Reminder = {firstNumber % secondNumber}");
        }
    }
}

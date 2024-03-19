using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            long rem, sum = 0;
            
            Console.Write("Enter the number = ");
            long number = long.Parse(Console.ReadLine());
            long copyOfNumber = number;
            while(number != 0)
            {
                rem = number % 10;
                sum += rem;
                number /= 10;
                if (number != 0) sum *= 10;
            }
            Console.WriteLine($"reverse of {copyOfNumber} is {sum}");
        }
    }
}

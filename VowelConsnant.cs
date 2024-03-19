using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class VowelConsnant
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Alpabet = ");
            char alpabet = char.Parse(Console.ReadLine());

            if (('a' <= alpabet && alpabet <= 'z') || ('A' <= alpabet && alpabet <= 'Z'))
            {
                if (alpabet == 'a' || alpabet == 'e' || alpabet == 'i' || alpabet == 'o' || alpabet == 'u' || alpabet == 'A' || alpabet == 'E' || alpabet == 'I' || alpabet == 'O' || alpabet == 'U')
                {
                    Console.WriteLine($"{alpabet} is an vowel !");
                }
                else Console.WriteLine($"{alpabet} is a consnant !");
            }
            else Console.WriteLine("Invalid input ! Enter an alpabet.");
        }
    }
}

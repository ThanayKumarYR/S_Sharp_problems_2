using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class LeapYear
    {
        static void Main()
        {


            try
            {
                Console.WriteLine("Welcome to leap year program !");
                Console.Write("Enter the year: ");
                string yearStr = Console.ReadLine();
                if (yearStr.Length != 4)
                {
                    Console.WriteLine("Please enter a 4 digit year !");
                    return;
                }

                int year = int.Parse(yearStr);

                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            Console.WriteLine($"{year} is leap year !");
                        }
                        else
                        {
                            Console.WriteLine($"{year} is not leap year!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{year} is leap year !");
                    }
                }
                else
                {
                    Console.WriteLine($"{year} is not leap year!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



    }
}

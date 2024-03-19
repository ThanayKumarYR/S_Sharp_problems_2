using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class HormonicNumbers
    {
        static void Main()
        {
            float nthTerm = 0;
            Console.WriteLine("Welcome to Hormonic Number !");
            Console.Write("Enter the value of N = ");
            int N = int.Parse(Console.ReadLine());

            if (N <= 0)
            { 
                Console.WriteLine("Enter the value of N greater than 0.");
                Main();
            }

            try 
            {
                for (float i = 1; i <= N; i++)
                {
                    nthTerm += 1 / i;
                }
                Console.WriteLine("Value of Nth Term = " + nthTerm);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}

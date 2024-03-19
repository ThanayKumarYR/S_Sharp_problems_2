using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class FibonacciSeriers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value of N = ");
            int N  = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            arr[0] = 0; arr[1] = 1;
            Console.Write(arr[0] + " "+ arr[1]);
            for (int i = 2; i < N; i++)
            {
                arr[i] = arr[i-1] + arr[i-2];
                Console.Write(" "+arr[i]);
            }
            Console.WriteLine();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_problems_2
{
    class LargestAmongThree
    {
        static void Main(string[] args)
        {

            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            int large = arr[0];
            foreach (var item in arr)
            {
                if(large<item) large = item;
                Console.Write(item + " ");
            }
            Console.WriteLine("\nLargest is " + large);    
        }
    }
}

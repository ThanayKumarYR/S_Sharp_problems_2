using System;
namespace CSharp_problems_2
{
    class FlipCoin
    {
        static void Main(string[] args)
        {
            float tails = 0, heads = 0;
            Console.WriteLine("Welcome to head or tails !\n");
            Console.Write("Enter the number of times to flip coin = ");
            int times = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < times; i++)
            {
                double coinValue = rnd.NextDouble();
                if (coinValue < 0.5) tails++;
                else heads++;
            }

            Console.WriteLine($"\nHeads % = {(heads/times)*100} % and Tails % = {(tails/times)*100} %");

        }
    }
}

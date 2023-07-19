// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

namespace Tutorial_C_Sharp
{
    class Program {
        static void Main(string[] args)
        {
            double total = CheckOut(3.99, 5.75, 15);
            Console.WriteLine(total);
            Console.ReadKey();
        }

        static double CheckOut(params double[] prices) {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }

    }
}
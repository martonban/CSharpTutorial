// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

namespace Tutorial_C_Sharp
{
    class Program { 
        
        static void Main(string[] args)
        {

            Random random = new Random();

            // Random Int
            random.Next();

            // Random int between parameters
            random.Next(1, 7);

            // Random Double 0-1
            double rnd = random.NextDouble();

            Console.WriteLine(rnd);
            Console.ReadKey();
        }
    }
}
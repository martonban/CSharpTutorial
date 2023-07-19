// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

namespace Tutorial_C_Sharp
{
    class Program { 
        
        static void Main(string[] args)
        {

            double a = 3.14;
            int b = Convert.ToInt32(a);

            Console.WriteLine(b);
            Console.WriteLine(a.GetType());

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;

            Console.WriteLine(d);

            Console.ReadKey();
            
        }
    }
}
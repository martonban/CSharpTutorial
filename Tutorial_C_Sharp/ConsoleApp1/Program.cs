// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

namespace Tutorial_C_Sharp
{
    class Program { 
        
        static void Main(string[] args)
        {

            Console.WriteLine("Type me a number: ");
            String number = Console.ReadLine();

            switch (number) 
            {
                case "one":
                    Console.WriteLine("It's a number");
                    break;
                case "two":
                    Console.WriteLine("It's a number");
                    break;
                case "three":
                    Console.WriteLine("It's a number");
                    break;
                case "four":
                    Console.WriteLine("It's a number");
                    break;
                case "five":
                    Console.WriteLine("It's a number");
                    break;
                case "six":
                    Console.WriteLine("It's a number");
                    break;
                case "seven":
                    Console.WriteLine("It's a number");
                    break;
                case "eight":
                    Console.WriteLine("It's a number");
                    break;
                case "nine":
                    Console.WriteLine("It's a number");
                    break;
                case "ten":
                    Console.WriteLine("It's a number");
                    break;
                default:
                    Console.WriteLine("It's not a number");
                    break;
            }

            Console.ReadKey();
        }
    }
}
// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.ComponentModel;

namespace Tutorial_C_Sharp
{
    class Program {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }


    class Car : Vehicle {

        public int wheels = 4;
    }


    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
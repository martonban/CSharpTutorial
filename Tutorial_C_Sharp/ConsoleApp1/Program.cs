﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.ComponentModel;

using System.Collections.Generic;
namespace Tutorial_C_Sharp
{
    class Program {
        static void Main(string[] args)
        {
            Car car = new Car(400);

            car.Speed = 1000000;

            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }

    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed {
            get { return speed; }   // read
            set {
                if (value > 500)
                {
                    speed = 500;
                }
                else { 
                    speed = value;
                }  
            }  
        }

    }

}
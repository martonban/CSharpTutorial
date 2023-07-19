// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Tutorial_C_Sharp
{
    class Program {
        static void Main(string[] args)
        {
            List<String> food = new List<String>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hot-dog");

            //food.Remove("pizza");
            //food.Insert(0, "sushi");
            //int i = food.Count;
            //int i = food.IndexOf("pizza");
            //bool t = food.Contains("pizza");
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            String[] foodArray = food.ToArray();

            Console.ReadKey();
        }
    }



}
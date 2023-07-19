// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.ComponentModel;

namespace Tutorial_C_Sharp
{
    class Program {
        static void Main(string[] args)
        {
            Human human1 = new Human("Rick", 65);
            Human human2 = new Human("Morty", 16);

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }



    class Human {

        public String name;
        public int age;


        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat() {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    
    }

}
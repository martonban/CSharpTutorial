// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.ComponentModel;

namespace Tutorial_C_Sharp
{
    class Program {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat= new Cat();

            dog.Speak();
            cat.Speak();


            Console.ReadKey();
        }
    }

    class Animal
    {
        // Every function which I want to overriding need to be vitual!!!
        // or abstruct but the class need to be abstract to
        public virtual void Speak() {
            Console.WriteLine("The animal goes *brrr*");
        }
    }


    class Dog : Animal {

        public override void Speak()
        {
            Console.WriteLine("WOOF");
        }
    }

    class Cat : Animal
    {

        public override void Speak()
        {
            Console.WriteLine("MEOW");
        }
    }
}
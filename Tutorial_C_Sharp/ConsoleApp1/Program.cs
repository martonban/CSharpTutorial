// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

namespace Tutorial_C_Sharp
{
    class Program {
        static void Main(string[] args)
        {

            Console.WriteLine("Game Rules");
            Console.WriteLine("Every round you will recive a random number. After you get the random number you need to guess the place. The number is going to stored in a list after all the ten round you will see, you gess the order well or not");

            int[] numbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int count = 0;
            Random rnd = new Random();

            while (count < 10) {


                int number = rnd.Next(1,100);

                Console.Write("Your number is: ");
                Console.WriteLine(number);
                Console.WriteLine("-------------------------");
                Console.WriteLine("List NOW");

                printList(numbers);

                Console.WriteLine("What is your guess?:");
                int guess = Convert.ToInt32(Console.ReadLine());
                
                numbers[guess] = number;
                count++;
            }

            if (isThisInOrder(numbers))
            {
                Console.WriteLine("VICTORY!!!");
            }
            else {
                Console.WriteLine("DEFEAT!!");
            }


            Console.ReadKey();
        }

        static void printList(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }

        static bool isThisInOrder(int[] array) {
            for (int i = 0; i < array.Length-1; i++) {
                if (array[i] > array[i + 1]) {
                    return false;
                }
            }
            return true;
        }
    }
}
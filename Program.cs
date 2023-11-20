// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Runtime.InteropServices;

namespace Begginer_LevelCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Tickets are 5$. Please insert cash.");
            int takenCash = Convert.ToInt32(Console.ReadLine());
            int rest = takenCash - 5;
            if(takenCash < 5)
            {
                Console.WriteLine("That's not enough money.");
            }else if (takenCash > 5){

                Console.WriteLine(" this is ur rest: " +rest);
            }
            else if (takenCash == 5)
            {

                Console.WriteLine("Thank you and enjoy the film");
            }
            Console.ReadKey();
        }
    }
}


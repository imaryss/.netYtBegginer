// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace Begginer_LevelCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the appearance 
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World");
            Console.WindowHeight = 40;

            //get a conversation going
            Console.WriteLine("Hello, what's your name?"); 
            Console.ReadLine();
            Console.WriteLine("My name is rx-9000. I'm an AI sent from the future to destroy mankind.");
            Console.WriteLine("What is ur favourite color");
            Console.ReadLine();
            Console.ReadKey();
//the things put inside here are going to appear when running the program
        }
    }
}


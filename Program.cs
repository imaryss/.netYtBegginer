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
            Console.WriteLine("What is ur name");
            var userName= Console.ReadLine();
            Console.WriteLine("Hello " + userName + ", nice to meet u" );

            Console.ReadKey();
//the things put inside here are going to appear when running the program
        }
    }
}


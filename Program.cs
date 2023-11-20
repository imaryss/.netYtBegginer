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
            double num01;
            double num02;
            Console.Write("Input a number: ");
            num01 = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Input a second number");
            num02 = Convert.ToDouble(Console.ReadLine());
            double result = num01 * num02;
            Console.WriteLine("The result is " + result);
            Console.ReadKey();
//the things put inside here are going to appear when running the program
        }
    }
}


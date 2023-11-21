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
            int age;
            int height;

            Console.WriteLine("please input your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input your height: ");
            height = Convert.ToInt32(Console.ReadLine());

            
            if( age>=18 && height >= 160 ){
                Console.WriteLine("You can enter!");
            }else{
                Console.WriteLine("you dont meet the requirements.");
            }
        //nesting= putting one if statement into an another
            Console.ReadKey();
        }
    }
}


using System;
using System.ComponentModel.Design.Serialization;

namespace IraLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your x");
            string stringX = Console.ReadLine();
            int x = int.Parse(stringX);
            Console.WriteLine($"X={x}");
            Console.WriteLine($"x*2={x*2}");
            Console.ReadKey();
        }
    }
}
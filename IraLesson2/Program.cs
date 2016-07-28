using System;
using System.ComponentModel.Design.Serialization;

namespace IraLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your x");
            string x = Console.ReadLine();
            Console.WriteLine("X={x}");//wihotu dollar and with dollar
            Console.WriteLine($"X={x}");
            int result = int.Parse(x);
            result *= 2;
            Console.WriteLine($"x*2={result}");
            Console.ReadKey();
        }
    }
}
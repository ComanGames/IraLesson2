using System;
using System.ComponentModel.Design.Serialization;

namespace IraLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5 + 6;//11
            a = a + 5;//16
            a += 5;//21
            a = a/2;
            a /= 2;
            a = a*2;
            a *= 2;
            a = a - 2;
            a -= 2;
            a = 5;// присвоэеня
            int b = 10;
            Console.WriteLine(b%15);
            Console.ReadKey();
            

        }
    }
}
using System;
using System.ComponentModel.Design.Serialization;

namespace IraLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "10";
            int a = 5;
            s = a.ToString();//convert int to string
            a = int.Parse(s); ///convert string to int
            string s1 = "5.00001";
            double d1 = double.Parse(s1); ///convert string to double
            short sh = 100;
            int i = sh; // conert short to int
            sh = (short)i; // convert int to short
            int b = 10;
            double d = b;// int to double
            b = (int)d;  // double to int

            a = 5;
            double d2 = a;
            d2 += 0.001;
            Console.WriteLine(d2);
            Console.ReadKey();
        }
    }
}

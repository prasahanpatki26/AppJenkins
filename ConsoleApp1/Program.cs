using System;
using MyCalc;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jetkins");
            Calc calc = new Calc();
            Console.WriteLine($"Sum = {calc.Add(70, 80)}");
            Console.WriteLine($"Multiply = {calc.Add(70, 80)}");
            Console.ReadLine();
        }
    }
}

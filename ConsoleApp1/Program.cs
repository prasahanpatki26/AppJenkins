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
            Console.WriteLine("This is from Second Edit");
            Calc calc = new Calc();
            Console.WriteLine($"Sum = {calc.Add(70, 80)}");
            Console.WriteLine($"Multiply = {calc.Multiply(70, 80)}");
            Console.WriteLine($"Multiply = {calc.Subtract(70, 80)}");
            Console.ReadLine();
        }
    }
}

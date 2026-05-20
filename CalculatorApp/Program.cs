using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(5, 3));
        }
    }
}
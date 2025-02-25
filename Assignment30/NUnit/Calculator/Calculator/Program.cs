using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArithmeticCalculator calculator = new ArithmeticCalculator();
            Console.WriteLine(calculator.Add(10, 20));
            Console.WriteLine(calculator.Subtract(10, 20));
            Console.WriteLine(calculator.Multiply(10, 20));
            Console.WriteLine(calculator.Divide(40, 20));
        }

    }
}

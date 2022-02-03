using System;

namespace Hand_test_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            var Calculator = new Calculator();

            double num1 = 3;
            double num2 = 5;

            var plus = Calculator.Add(num1, num2);
            var minus = Calculator.Subtract(num1, num2);
            var gange = Calculator.Multiply(num1, num2);
            var exp = Calculator.Power(num1, num2);
            var dividere = Calculator.Divide(num1, num2);

            Console.WriteLine("Adding " + num1 + " and " + num2);
            Console.WriteLine("Result: " + plus);
            Console.WriteLine("Subtracting " + num2 + " from " + num1);
            Console.WriteLine("Result: " + minus);
            Console.WriteLine("Multiplying " + num1 + " and " + num2);
            Console.WriteLine("Result: " + gange);
            Console.WriteLine( num1 + " to the power of " + num2);
            Console.WriteLine("Result: " + exp);
            Console.WriteLine("Dividing " + num2 + " with " + num1);
            Console.WriteLine("Result: " + dividere);

            Console.ReadKey();
        }
    }
}

using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());//10
            int numberTwo = int.Parse(Console.ReadLine());//12
            string symbol = Console.ReadLine();//+
            switch (symbol)
            {
                case "+":
                    double symbolPlus = number + numberTwo;//10 + 12 = 22
                    if(symbolPlus % 2 == 0)
                    {
                        Console.WriteLine($"{number} + {numberTwo} = {symbolPlus} - even");
                    } else
                    {
                        Console.WriteLine($"{number} + {numberTwo} = {symbolPlus} - odd");
                    }
                    break;
                case "-":
                    double symbolMinus = number - numberTwo;
                    if (symbolMinus % 2 == 0)
                    {
                        Console.WriteLine($"{number} - {numberTwo} = {symbolMinus} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number} - {numberTwo} = {symbolMinus} - odd");
                    }
                    break;
                case "*":
                    double symbolMultiply = number * numberTwo;
                    if (symbolMultiply % 2 == 0)
                    {
                        Console.WriteLine($"{number} * {numberTwo} = {symbolMultiply} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number} * {numberTwo} = {symbolMultiply} - odd");
                    }
                    break;
                case "/":
                    if (number != 0 && numberTwo != 0)
                    { 
                        double symbolDivided = number / numberTwo;                 
                        Console.WriteLine($"{number} / {numberTwo} = {symbolDivided:f2}");
                    }
                    else 
                    {
                        Console.WriteLine($"Cannot divide {number} by zero");
                    }
                    break;
                case "%":
                    if (number != 0 && numberTwo != 0)
                    {
                        double symbolPercent = number % numberTwo;
                        Console.WriteLine($"{number} % {numberTwo} = {symbolPercent}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {number} by zero");
                    }
                    break;
            }
        }
    }
}

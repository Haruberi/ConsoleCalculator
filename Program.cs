using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathOp = new MathematicalOperations();

            string mathOptions;
            bool running = true;
            while (running)
            {
                //Menu system for mathematical operations and an Exit option
                Console.Clear();
                Console.WriteLine("  Choose an option within the parantheses:\n ");
                Console.WriteLine("\t|-----------------------|");
                Console.WriteLine("\t| (+) Addition          |");
                Console.WriteLine("\t|-----------------------|");
                Console.WriteLine("\t| (-) Subtraction       |");
                Console.WriteLine("\t|-----------------------|");
                Console.WriteLine("\t| (x) Multiplication    |");
                Console.WriteLine("\t|-----------------------|");
                Console.WriteLine("\t| (/) Division          |");
                Console.WriteLine("\t|-----------------------|");
                Console.WriteLine("\t| (e) Exit              |");
                Console.WriteLine("\t|-----------------------|");

                mathOptions = Console.ReadLine();
                switch (mathOptions)
                {
                    //Each method is located at class MathematicalOperations.cs
                    case "+":
                        mathOp.Add();
                        break;
                    case "-":
                        mathOp.Subtract();
                        break;
                    case "x":
                        mathOp.Multiplicate();
                        break;
                    case "/":
                        mathOp.Divide();
                        break;
                    case "e":
                        mathOp.ExitCalculator();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}



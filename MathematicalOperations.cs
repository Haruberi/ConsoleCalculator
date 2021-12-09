using System;
namespace Calculator
{
    public class MathematicalOperations
    {
        public double numberOne;
        public string numberOneString = "";
        public string numberTwoString = "";
        public double numberTwo;
        public double result;
        public bool succeed = false;

        public MathematicalOperations()
        {
        }

        /* This method will be executed when the user types + 
         * There will be a check to see if the inserted value is invalid.
         * A string will be executed to tell the user if the input is invalid. 
         * Lastly, when two correct numbers has been inserted, 
           the result of the two numbers will be calculated and executed.*/

        public void Add()
        {
            Console.Clear();
            Console.WriteLine("\t+ + Addition + +\n");
            Console.WriteLine("Type a number: ");

            var numberOneString = Console.ReadLine();

            while (!double.TryParse(numberOneString, out numberOne))
            {
                Console.WriteLine("Invalid number. Please enter a valid number:");
                numberOneString = Console.ReadLine();
            }

            Console.WriteLine("Type another number, then press enter: ");
            var numberTwoString = Console.ReadLine();

            while (!double.TryParse(numberTwoString, out numberTwo))
            {
                Console.WriteLine("Invalid number. Please enter a valid number: ");
                numberTwoString = Console.ReadLine();
            }
            result = numberOne + numberTwo;
            Console.WriteLine("{0} + {1} = {2}", numberOne, numberTwo, result);
        }


        /* This method will be executed when the user types - 
        *  There will be a check to see if the inserted value is invalid.
        *  A string will be executed to tell the user if the input is invalid. 
         * Lastly, when two correct numbers has been inserted, 
         * the result of the two numbers will be calculated and executed.*/

        public void Subtract()
        {
            Console.Clear();
            Console.WriteLine("\t- - Subtraction - -\n");
            Console.WriteLine("Type a number: ");

            var numberOneString = Console.ReadLine();
            while (!double.TryParse(numberOneString, out numberOne))
            {
                Console.WriteLine("Invalid number. Please enter a valid number:");
                numberOneString = Console.ReadLine();
            }

            Console.WriteLine("Type another number, then press enter: ");
            var numberTwoString = Console.ReadLine();
            while (!double.TryParse(numberTwoString, out numberTwo))
            {
                Console.WriteLine("Invalid number. Please enter a valid number: ");
                numberTwoString = Console.ReadLine();
            }

            result = numberOne - numberTwo;
            Console.WriteLine("{0} - {1} = {2}", numberOne, numberTwo, result);
        }

        /* This method will be executed when the user types x 
         * There will be a check to see if the inserted value is invalid.
         * A string will be executed to tell the user if the input is invalid. 
         * Lastly, when two correct numbers has been inserted, 
           the result of the two numbers will be calculated and executed.*/

        public void Multiplicate()
        {
            Console.Clear();
            Console.WriteLine("\tx x Multiplication x x\n");
            Console.WriteLine("Type a number: ");

            var numberOneString = Console.ReadLine();
            while (!double.TryParse(numberOneString, out numberOne))
            {
                Console.WriteLine("Invalid number. Please enter a valid number:");
                numberOneString = Console.ReadLine();
            }

            Console.WriteLine("Type another number, then press enter: ");
            var numberTwoString = Console.ReadLine();
            while (!double.TryParse(numberTwoString, out numberTwo))
            {
                Console.WriteLine("Invalid number. Please enter a valid number: ");
                numberTwoString = Console.ReadLine();
            }

            result = numberOne * numberTwo;
            Console.WriteLine("{0} x {1} = {2}", numberOne, numberTwo, result);
        }

        /* This method will be executed when the user types / 
         * There will be a check to see if the inserted value is 0 or if it is invalid.
         * A string will be executed to tell the user if the input is invalid. 
         * Lastly, when two correct numbers has been inserted, 
           the result of the two numbers will be calculated and executed.*/

        public void Divide()
        {
            Console.Clear();
            Console.WriteLine("\t/ / Division / /\n");
            Console.WriteLine("Type a number: ");

            var numberOneString = Console.ReadLine();
            while (!double.TryParse(numberOneString, out numberOne) || numberOneString == "0")
            {
                Console.WriteLine("Invalid number. Please enter a valid number:");
                numberOneString = Console.ReadLine();
            }

            Console.WriteLine("Type another number, then press enter: ");
            var numberTwoString = Console.ReadLine();
            while (!double.TryParse(numberTwoString, out numberTwo) || numberTwoString == "0")
            {
                Console.WriteLine("Invalid number. Please enter a valid number: ");
                numberTwoString = Console.ReadLine();
            }

            result = numberOne / numberTwo;
            Console.WriteLine("{0} / {1} = {2}", numberOne, numberTwo, result);
        }

        /*This method will be executed when the user types e 
          This method will close the Calculator application.*/

        public void ExitCalculator()
        {
            Console.Clear();
            Console.WriteLine("\t Press\n\t ENTER\n to close the calculator.");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}

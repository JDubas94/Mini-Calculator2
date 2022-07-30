using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstNumber, SecondNumber;

            string decision;

            Console.WriteLine("Enter the first number:");

            FirstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");

            SecondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation: '+', '-', '*', '/' ");

            decision = Console.ReadLine();

            switch (decision)
            {
                case "+":
                    Console.WriteLine(FirstNumber + SecondNumber);
                    break;
                case "-":
                    Console.WriteLine(FirstNumber - SecondNumber);
                    break;
                case "*":
                    Console.WriteLine(FirstNumber * SecondNumber);
                    break;
                case "/":
                    Console.WriteLine(FirstNumber / SecondNumber);
                    break;
            }
        }
    }
}

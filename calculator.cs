using System;
using System.Threading;

namespace AnimatedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Animated Calculator";

            Console.WriteLine("Welcome to the Animated Calculator!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Please select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Thank you for using the Animated Calculator!");
                    break;
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine();

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Calculating...");

                for (int i = 0; i <= 100; i += 20)
                {
                    Console.Write($"\rProgress: {i}%");
                    Thread.Sleep(200);
                }

                Console.WriteLine();
                Console.WriteLine();

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            continue;
                        }
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

using System;

// Simple calculator class
public class Calculator
{
    // Addition operation
    public double Add(double a, double b)
    {
        // Addition Operation
        return a + b;
    }

    // Subtraction operation
    public double Subtract(double a, double b)
    {
        // Subtraction Operation
        return a - b;
    }

    // Multiplication operation
    public double Multiply(double a, double b)
    {
        // Multiplication Operation
        return a * b;
    }

    // Division operation
    public double Divide(double a, double b)
    {
        // Division Operation
        if (b == 0)
        {
            throw new ArgumentException("Division by zero is not allowed");
        }
        return a / b;
    }
}

// Main application code
public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        if (args.Length < 3)
        {
            Console.WriteLine("Usage: dotnet run <operation> <num1> <num2>");
            Console.WriteLine("Operations: add, subtract, multiply, divide");
            return;
        }

        string operation = args[0];
        double a = double.Parse(args[1]);
        double b = double.Parse(args[2]);

        switch (operation)
        {
            case "add":
                Console.WriteLine("Addition: " + calc.Add(a, b));
                break;
            case "subtract":
                Console.WriteLine("Subtraction: " + calc.Subtract(a, b));
                break;
            case "multiply":
                Console.WriteLine("Multiplication: " + calc.Multiply(a, b));
                break;
            case "divide":
                try
                {
                    Console.WriteLine("Division: " + calc.Divide(a, b));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            default:
                Console.WriteLine("Invalid operation. Use add, subtract, multiply, or divide.");
                break;
        }
    }
}

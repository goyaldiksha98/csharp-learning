using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 20;
        int b = 6;

        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Remainder: " + (a % b));

        int x = 10;

        Console.WriteLine(x++);

        Console.WriteLine(x);

        Console.WriteLine(++x);
    }
}
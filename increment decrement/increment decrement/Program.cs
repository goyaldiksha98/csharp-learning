using System;

class Program
{
    static void Main()
    {
        int x = 10;

        Console.WriteLine("Initial x = " + x);

        Console.WriteLine("Post Increment = " + x++);

        Console.WriteLine("After Post Increment = " + x);

        Console.WriteLine("Pre Increment = " + ++x);

        Console.WriteLine("Final x = " + x);
    }
}
using System;

class Program
{
    static void Main()
    {
        int marks = 80;

        Console.WriteLine("Initial Marks = " + marks);

        marks += 10;
        Console.WriteLine("After Bonus = " + marks);

        marks -= 20;
        Console.WriteLine("After Penalty = " + marks);

        marks *= 2;
        Console.WriteLine("After Double = " + marks);

        marks /= 5;
        Console.WriteLine("After Divide = " + marks);

        marks %= 7;
        Console.WriteLine("Remainder = " + marks);
    }
}
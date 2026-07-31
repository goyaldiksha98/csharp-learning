using System;
class Program
{
    static void Main(string[] args)
    {
        string firstname = "Diksha";
        string Lastname = "Goyal";
        Console.WriteLine(firstname);
        Console.WriteLine(Lastname);
        Lastname = "sharma";
        Console.WriteLine(firstname);
        Console.WriteLine(Lastname);


        int x = 5;
        int y = x;

        string a = "ABC";
        string b = a;

        x = 20;
        a = "XYZ";

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(20 / 6);
        Console.WriteLine(20 % 6);
    }
}
using System;

namespace Day01_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Diksha Bansal");
            Console.WriteLine("I am learning C#");
            Console.WriteLine("I want to become asp.Net developer");
            Console.WriteLine("Thankyou");
            int age = 22;
             age = 30;
            string name = "Diksha";
            string city = "panchkula";
            double percentage = 73.5;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(city);
            Console.WriteLine(percentage);

            int x = 10;
            int y = x;
            x = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);

            int a = 15;
            int b = 20;
            a = 30;
            b = 40;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c = 50;
            int d = c;
            int e = d;

            c = 100;
            d = 200;

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            int g = 10;
            int h = g;
            g = h;
            h = 50;
            Console.WriteLine(g);
            Console.WriteLine(h);

            int i = 5;
            int j = i;
            i = i + 10;
            j = j + 20;
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}
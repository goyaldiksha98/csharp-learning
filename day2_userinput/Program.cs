using System;

namespace Day01_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name : ");

            string name = Console.ReadLine();

            

            Console.Write("Enter Your city : ");

            string city = Console.ReadLine();

            

            Console.Write("Enter Your course: ");

            string course = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(city);

            Console.WriteLine(course);


            Console.Write("Enter Marks: ");

            double marks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(marks);

        }
    }
}
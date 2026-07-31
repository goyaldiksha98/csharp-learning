using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject_college_admission_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            bool eligible = age >= 18 && marks >= 60;

            Console.WriteLine("Admission Eligible: " + eligible);

            Console.ReadLine();
        }
    }
}

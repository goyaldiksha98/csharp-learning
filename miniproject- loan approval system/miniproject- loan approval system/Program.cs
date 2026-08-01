using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject__loan_approval_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 21)
            {

                Console.WriteLine("Enter Salary");
                int salary = Convert.ToInt32(Console.ReadLine());


                if (salary >= 30000)
                {
                    Console.WriteLine("Loan Approved");
                }
                else
                {
                    Console.WriteLine("Low Salary");
                }
            }
            else
            {
                Console.WriteLine("Age Not Eligible");

            }
            
            Console.WriteLine("Process Completed");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject__Scholarship_Eligibility_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sport Quota(yes/no): ");
            string sportquota = Console.ReadLine();
            
            if (marks >= 90 || sportquota == "yes")
            {
                Console.WriteLine("Scholarship Approved");
            }
            else
            {
                Console.WriteLine("Scholarship Rejected");
            }

            Console.WriteLine("Thank You");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject__pass_fail_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Marks: ");
            int Marks = Convert.ToInt32(Console.ReadLine());

            if (Marks >= 33)
            {
                Console.WriteLine("You are pass");
            }
            else
            {
                Console.WriteLine("you are fail");
            }

            Console.ReadLine();
        }
    }
}

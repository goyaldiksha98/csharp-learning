using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject_voting_elegibility
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {

                Console.WriteLine("you are eligible for voting");
                    }
            else
            {
                Console.WriteLine("not eligible");
            }
        }
    }
}


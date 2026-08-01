using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace conditional_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            if(age>=18)
            {
                Console.WriteLine("you can vote");

            }
            Console.WriteLine("Not elligible");

            int marks = 20;

            if (marks >= 33)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("fail");

            }

        }

    }
}

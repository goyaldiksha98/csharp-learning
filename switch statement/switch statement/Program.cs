using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 2;

            switch (number)
            {
                case 1:
                    Console.WriteLine("Red");
                    break;

                case 2:
                    Console.WriteLine("Green");
                    break;

                case 3:
                    Console.WriteLine("Blue");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}

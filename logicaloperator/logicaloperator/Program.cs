using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaloperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            int marks = 70;

            Console.WriteLine(age >= 18 || marks >= 60);
            Console.WriteLine(age >= 18 && marks >= 70);


            string degree = "MCA";

            Console.WriteLine(degree == "BCA" || degree == "MCA");


            bool isloggedIn = true;
            Console.WriteLine(!isloggedIn);



        }
    }
}

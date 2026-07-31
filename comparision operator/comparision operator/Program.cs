using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparision_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 20;
            Console.WriteLine(a == b);


            int x = 20;
            int y = 30;
            Console.WriteLine(x != y);


            int marks = 85;
            Console.WriteLine(marks > 50);
            Console.WriteLine(marks < 70);
            Console.WriteLine(marks <= 85);
            Console.WriteLine(marks >= 85);


            string username = "admin";
            Console.WriteLine(username == "admin");
            bool result = 20 > 10;
            Console.WriteLine(result);

            bool answer = 5 == 8;
            Console.WriteLine(answer);


            Console.Write("enter student emarks:");
            int emarks = Convert.ToInt32(Console.ReadLine());
            bool isPass = emarks >= 33;
            Console.WriteLine("Pass Status:" + isPass);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int i = 10;
             do
             {
                 Console.WriteLine(i);
                 i--;
             }
             while (i >=1); */
            int password;

            do
            {
                Console.Write("Enter Password: ");
                password = Convert.ToInt32(Console.ReadLine());

                if (password == 1234)
                {
                    Console.WriteLine("Login Successfully");
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                }

            }
            while (password!=1234);





        }
    }
}

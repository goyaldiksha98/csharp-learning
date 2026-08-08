using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject__Logic_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int attempt = 1;


            while (attempt <= 3)
            {
                Console.Write("Enter a Password:");
                int Password = Convert.ToInt32(Console.ReadLine());
                if (Password == 1234)
                {
                    Console.WriteLine("Login Successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                }
                
                if (attempt == 3)
                {
                    Console.WriteLine("Account Locked");
                    break;

                }
                attempt++;

            }
        }
    }
}

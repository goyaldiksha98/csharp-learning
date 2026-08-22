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

            string correctUsername = "admin";
            string correctPassword = "admin123";

            while (attempt <= 3)
            {
                Console.Write("Enter your Username: ");
                string name = Console.ReadLine();

                Console.Write("Enter your Password: ");
                string password = Console.ReadLine();

                if (name == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login Successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Username or Password");

                    int remaining = 3 - attempt;

                    if (remaining == 0)
                    {
                        Console.WriteLine("Account Locked");
                        break;
                    }

                    Console.WriteLine("Attempts Remaining = " + remaining);
                }

                attempt++;
            }
        }
    }
}

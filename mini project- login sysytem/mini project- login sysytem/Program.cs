using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project__login_sysytem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (username =="admin")
            {
                if (password == "1234")
                {
                    Console.WriteLine("login successful");
                }
                else
                {
                    Console.WriteLine("wrong password");
                }
            }
            else
            {
                Console.WriteLine("wrong username");
            }
            }
        }
    }


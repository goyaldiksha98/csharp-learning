using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject_shoping_discount_sysytem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Purchase Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Are you a member(yes/no): ");
            string member = Console.ReadLine();

            if (amount >= 5000 && member == "yes")
            {
                Console.WriteLine("20% Discount Applied");
            }
            else
            {
                Console.WriteLine("No Discount");
            }

            Console.WriteLine("Thank You");
        }
            
        }
    }

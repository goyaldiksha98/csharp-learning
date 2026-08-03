using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject__ATM_Menu_System
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("=============ATM MENU============");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your Balance is Rs. 50,000");
                    break;

                case 2:
                    Console.WriteLine("Withdraw Successful");
                    break;

                case 3:
                    Console.WriteLine("Amount Deposited Successfully");
                    break;

                case 4:
                    Console.WriteLine("Thank You for Using Our ATM");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minproject___ATM_PIN_verification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Card (yes/no): ");
            string card = Console.ReadLine();

            Console.Write("Enter Pin: ");
            string pin = Console.ReadLine();

            if (card == "yes")
            {
                if (pin == "1234")
                {
                    Console.WriteLine("Withdrawal Allowed");
                }
                else
                {
                    Console.WriteLine("wrong pin");
                }
            }
            else
            {
                Console.WriteLine("Card not Inserted");
            }

            Console.WriteLine("Thankyou");
        }
    }
}
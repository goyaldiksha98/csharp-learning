using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace miniproject_atm_menu_using_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======ATM=====");
            int choice;
            int balance = 50000;
            do
            {
                Console.WriteLine("1.Check Balance");
                
                Console.WriteLine("2.Withdraw");
                
                Console.WriteLine("3.Deposite");
                
                Console.WriteLine("4.Exit");
                Console.Write("Enter Your Choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your Balance is Rs. " + balance);

                        break;

                    case 2:
                        Console.Write("Enter Withdraw Amount:");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw <= balance && withdraw>0)
                        {
                            Console.WriteLine(withdraw + ":-" + "Withdraw Successful");
                            balance = balance - withdraw;
                            Console.WriteLine("Your Balance is Rs." + balance);
                        }
                        else
                        {
                            Console.WriteLine("Amount Invalid");
                        }
                       
                    break;

                    case 3:
                        Console.Write("Enter Deposite Amount:");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        if (deposit > 0)
                        {


                            Console.WriteLine(deposit + "Amount Deposited Successfully");
                            balance = balance + deposit;
                            Console.WriteLine("Your Balance is Rs." + balance);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Deposit amount");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thank You for Using Our ATM");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }


            }
            while (choice !=4) ;

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject__language_selection_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Select Language=======");
            Console.WriteLine("1.English");
            Console.WriteLine("2.Hindi");
            Console.Write("Enter Your Choice:");
            int language = Convert.ToInt32(Console.ReadLine());
            switch (language)
            {
                case 1:
                    Console.WriteLine("English Selected");
                    Console.WriteLine("1.Login");
                    Console.WriteLine("2.Register");
                    Console.WriteLine("3.Exit");
                    Console.Write("Enter your choice:");
                    int menuChoice = Convert.ToInt32(Console.ReadLine());
                    switch(menuChoice)
                    {
                        case 1:
                            Console.WriteLine("Login Selected");
                            break;
                        case 2:
                            Console.WriteLine("Register selected");
                            break;
                        case 3:
                            Console.WriteLine("Exit Selected");
                            break;
                        default:
                            Console.WriteLine("Invalid Menu Choice");
                                break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Hindi Selected");
                    Console.WriteLine("1. लॉगिन");
                    Console.WriteLine("2.रजिस्टर");
                    Console.WriteLine("3. बाहर निकलें");
                    Console.Write("अपना विकल्प चुनें: ");
                    int hindichoice = Convert.ToInt32(Console.ReadLine());
                    switch (hindichoice)
                    {
                        case 1:
                            Console.WriteLine("लॉगिन चुना गया");
                            break;
                        case 2:
                            Console.WriteLine("रजिस्टर चुना गया");
                            break;
                        case 3:
                            Console.WriteLine("बाहर निकल रहे हैं");
                            break;
                        default:
                            Console.WriteLine("अमान्य विकल्प");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
    }
}

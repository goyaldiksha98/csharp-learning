using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject_Number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool won = false;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter your guess: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 7)
                {
                    Console.WriteLine("Correct! You Won");
                    won = true;
                    break;
                }

                if (num < 7)
                {
                    Console.WriteLine("Too Low");
                }

                if (num > 7)
                {
                    Console.WriteLine("Too High");
                }
            }

            if (!won)
            {
                Console.WriteLine("Game Over");
            }

        }
    }
}

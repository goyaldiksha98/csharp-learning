using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine(numbers[i]);
             }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }



            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
                Console.WriteLine("Sum = " + sum);
            
            int[] numbers = { 10, 20, 30, 40, 50 };

            int largest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            Console.WriteLine("Largest Number = " + largest);


            int[] numbers = { 10, 20, 30, 40, 50 };

            int smallest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            Console.WriteLine("Smallest Number = " + smallest);




            int[] numbers = { 10, 20, 30, 40, 50 };

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum = sum + numbers[i];
                }
            }

            Console.WriteLine("Sum = " + sum);



            int[] numbers = { 10, 20, 30, 40, 50 };

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);


            int[] numbers = { 10, 15, 20, 25, 30, 35 };

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count); 


            int[] numbers = { 10, 20, 30, 40, 50 };
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
            


            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.Write("enter a number:");
            int search = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    found = true;
                    index = i;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Number Found at Index " + index);
            }
            else
            {
                Console.WriteLine("Number Not Found");
            }
            


            int[] numbers = { 10, 20, 10, 30, 10, 40 };
            Console.Write("enter a number:");
            int search = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    count++;
                }
            }
                Console.WriteLine(search + "appear"+count + "time");

            int[] numbers = { 10, 20, 30, 40, 50 };

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            int average = sum / numbers.Length;

            Console.WriteLine("Average = " + average);


            int[] numbers = { 10, -5, 20, -8, 15, -3 ,0};
            int positive = 0;
            int negative = 0;
            int zero = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positive++;
                }
                else if (numbers[i] < 0)
                {
                    negative++;
                }
                else 
                    {
                    zero++;

                }

                }
                Console.WriteLine("Positive Numbers = " + positive);
            Console.WriteLine("Negative Numbers = " + negative);
            Console.WriteLine("zero numbers=" + zero);
            


            int[] numbers = { 10, 50, 30, 40, 20 };
            int largest = numbers[0];
            int secondLargest = numbers[0];
            for(int i=0;i<numbers.Length;i++)
            {
                if(numbers[i] > largest)
                {

                    secondLargest = largest;
                    largest = numbers[i];
                }
                else if (numbers[i] > secondLargest)
                {
                    secondLargest = numbers[i];
                }
            }
        
                Console.WriteLine("Largest = " + largest);
                Console.WriteLine("Second Largest = " + secondLargest);
        

            int[] numbers = { 10, 20, 10, 30, 20, 40 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Console.WriteLine("Duplicate Number: " + numbers[i]);
                    }
                }
            }*/

            int[] numbers = { 10, 10, 10, 20, 20, 30 };
            
            for (int i = 0; i < numbers.Length; i++)

            {
                bool alreadyPrinted = false;
                for (int k = 0; k < i; k++)
                {
                    if (numbers[k] == numbers[i])
                    {
                        alreadyPrinted = true;
                        break;
                    }
                }
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j] && !alreadyPrinted)
                        {
                            Console.WriteLine("Duplicate Number: " + numbers[i]);
                        break;
                        }
                    }
                }

            















        }
    }
}


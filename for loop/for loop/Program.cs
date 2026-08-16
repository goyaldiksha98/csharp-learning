using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* for(int i=1; i<=10;i++)
             {
                 Console.WriteLine(i);
             }*/




            /* for(int i=10;i>=1; i--)
              {
                  Console.WriteLine(i);
              }*/



            /*for (int i = 2; i <= 10; i = i + 2) 
            {
                Console.WriteLine(i);}*/


            /* for( int i=3;i<=10; i=i+2)
             {
                 Console.WriteLine(i);
             }*/


            /* Console.Write("Enter A Number:");
             int num = Convert.ToInt32(Console.ReadLine());

             for(int i=1;i<=10; i++)
             {
                 Console.WriteLine(num + "*" + i + "=" + num * i);
             }*/


            /* Console.Write("Enter a Number:");
             int num = Convert.ToInt32(Console.ReadLine());
             int sum = 0;
             for (int i = 1; i <= num; i++)
             {
                 sum = sum + i;
             }

             Console.WriteLine("Sum = " + sum);



            Console.Write("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial = " + fact);


            Console.Write("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            

            Console.Write("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Write("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Total Even Numbers = " + count);
            


            Console.Write("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Total Odd Numbers = " + count);



            Console.Write("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    sum=sum+i;
                }
            }

            Console.WriteLine("Sum of Odd Numbers = " + sum);



            int largest = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter a Number:");
                int num = Convert.ToInt32(Console.ReadLine());
               

                if (num > largest) 
                {
                    largest = num;
                }
            }
            Console.WriteLine("largest Number:"+ largest);


            int smallest = 0; ;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter a Number:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    smallest = num;
                }
                else if (num < smallest)
                {
                    smallest = num;
                }
            }

            Console.WriteLine("Smallest Number: " + smallest);





            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("*");
                }
            }


            for (int i = 1; i <= 3; i++)       // rows
            {
                for (int j = 1; j <= 5; j++)   // stars
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }




            for(int i=5; i>=1;i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




            for( int i=1; i<=5; i++)
            {
                for(int j=1; j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }



            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i-1;j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * (6 - i) - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }


            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter Number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                Console.WriteLine(num);
            }



            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter Number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    continue;
                }

                Console.WriteLine(num);
            }
            


            for (int i = 1; i <= 30; i++)
            {
                if (i%3==0)
                {
                    continue;
                }
                if (i==20)
                {
                    break;
                }

                Console.WriteLine(i);
            }*/

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter Number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {
                    continue;
                }
                if (num == 0)
                {
                    break;
                }
                

                    Console.WriteLine(num);
                
            }






        }
    }
}

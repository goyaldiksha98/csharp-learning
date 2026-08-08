using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int i = 1;

            while (i<=5)
            {
                Console.WriteLine(i*10);
                i++;
            }

            int z = 10;
            while(z>=1)
            {
                Console.WriteLine(z);
                z--;
            }
            Console.Write("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int b=1;
            while(b<=num)
            {
                Console.WriteLine(b);
                b++;
            }


            Console.Write("Enter a Number:");
            int multi = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            while(a<=10)
            {
                Console.WriteLine(multi + "*" + a + "=" + multi*a);
                a++;
            }

            int k = 1;

            while (k <= 10)
            {
                Console.WriteLine(k);
                k = k + 2;
            }

            int g= 10;

            while (g >=2 )
            {
                Console.WriteLine(g);
                g = g - 2;
            }


            Console.Write("Enter a Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int h = 1;
             int sum = 0;
            while(h<=number)
            {

                sum = sum + h;
                h++;
            }
            Console.WriteLine("Sum = " + sum); */


            Console.Write("Enter a Number:");
            int fact = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            int multiple = 1;
            while (p <= fact)
            {

                multiple = multiple * p;
                p++;
            }
            Console.WriteLine("factorial = " + multiple);
        }
    }
}

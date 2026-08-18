using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject__Student_Marks_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 78, 35, 92, 25, 88 };
            int sum = 0;
            int lowest = marks[0];
            int highest = marks[0];
            int pass = 0;
            int fail = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum = marks[i] + sum;
                if (marks[i] > highest)
                {

                    highest = marks[i];
                }
                if (marks[i] < lowest)
                {
                    lowest = marks[i];


                }
                if (marks[i] >= 40)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
            }
            double average = (double)sum / marks.Length;
            Console.WriteLine("Total Marks = " + sum);
            Console.WriteLine("average marks= " + average);
            Console.WriteLine("Highest Marks = " + highest);
            Console.WriteLine("Lowest Marks = " + lowest);
            Console.WriteLine("Pass Students = " + pass);
            Console.WriteLine("Fail Students = " + fail);
        }
    }
}

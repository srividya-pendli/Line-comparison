using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_comaprison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to line comparison");
            {
                double x1, y1, x2, y2, x3, y3, x4, y4, length1, length2;
                x1 = 3;
                y1 = 5;
                x2 = 8;
                y2 = 9;
                x3 = 5;
                y3 = 6;
                x4 = 7;
                y4 = 4;
                length1 = Math.Sqrt(Math.Abs((x2 - x1) * (x2 - x1) + (x2 - x1) + (y2 - y1) * (y2 - y1) * (y2 = y1)));
                length2 = Math.Sqrt(Math.Abs((x4 - x3) * (x4 - x3) + (x4 - x3) + (y4 - y3) * (y4 - y3) * (y4 = y3)));
                Console.WriteLine("Length of first line is:{0} and second line is:{1}", length1,length2);
                if (length1 == length2)
                    Console.WriteLine("Two lines are equal");
                else if (length1 > length2)
                    Console.WriteLine("first line is greaterthan the second line");
                else
                    Console.WriteLine("first line is lessthan the second line");
                Console.ReadLine();
            }
        }
    }
}
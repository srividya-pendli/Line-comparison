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
                double x1, y1, x2, y2, length;
                x1 = 3;
                y1 = 5;
                x2 = 8;
                y2 = 9;
                length = Math.Sqrt(Math.Abs((x2 - x1) * (x2 - x1) + (x2 - x1) + (y2 - y1) * (y2 - y1) * (y2 = y1)));
                Console.WriteLine("Length of two points is:{0}", length);
                Console.ReadLine();
            }
        }
    }
}
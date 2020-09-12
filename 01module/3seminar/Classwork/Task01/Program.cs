using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void M(int a, int b, int c)
        {
            int d;
            d = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(d)) / 2;
            double x2 = (-b - Math.Sqrt(d)) / 2;
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            
            if (d < 0)
            {
                Console.WriteLine("нет вещественных корней");
                if (a == b&&b == c)
                {
                    Console.WriteLine("False");
                }
                if (a==b&&c!=0)
                {
                    Console.WriteLine("False");
                }

            }
            else
            {
                Console.WriteLine("true");
            }


        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            M(x, y, z);

        }
    }
}

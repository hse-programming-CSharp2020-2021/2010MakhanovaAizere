using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите катеты а и b");
            string k1 = Console.ReadLine();
            a = double.Parse(k1);
            string k2 = Console.ReadLine();
            b = double.Parse(k2);
            double c= Math.Sqrt((a*a)+(b*b));    
            Console.WriteLine("Гипотенуза с=" + c);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n,
                b;
            
            string k = Console.ReadLine();
            n = double.Parse(k);
            b = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine((Math.Pow(b, n)-Math.Pow(-b, -n))/(2*b-1));

        }
    }
}

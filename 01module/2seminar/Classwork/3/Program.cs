using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Method()
        {
            double b, res, n;
            string k = Console.ReadLine();
            n = double.Parse(k);
            b = (1 + Math.Sqrt(5)) / 2;
            res = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);


        }
        static void Main(string[] args)
        {
            int r;
            r = Method(res);
            Console.WriteLine(r);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            char number = (char)random.Next(96, 123);
            Console.WriteLine(number);
        }
    }
}

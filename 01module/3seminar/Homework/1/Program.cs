using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n * (n + 1) % 222 != 0) n++;
            int d = n * (n + 1) / 2;
            Console.WriteLine(d);
        }
    }
}

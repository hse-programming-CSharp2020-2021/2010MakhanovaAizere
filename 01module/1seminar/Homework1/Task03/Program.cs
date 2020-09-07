using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 32 до 127");
            int a = int.Parse(Console.ReadLine());

            if (a >= 32 && a <= 127)
            {
                char b = (char)a;
                Console.WriteLine("ASCII:" + b);
            }
            else
            {
                Console.WriteLine("Ошибка");

            }
        }
    }
}

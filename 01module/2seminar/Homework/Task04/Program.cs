using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        public static string Method(int n)
        {
            string k;
            k = n >= (int)'А' && n <= (int)'я' ? "Это буква!" : n >= (int)'0' && n <= (int)'9' ? "Это цифра!" : "Это ни буква, ни цифра!";
            return k;
        }

        static void Main(string[] args)
        {
            do//do{}while() можно заменить на просто while()
            {
                Console.Clear();

                int n=int.Parse(Console.ReadLine());
                Console.WriteLine($"{Method(n)}");
                Console.WriteLine("Нажмите ESC для выхода");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape); 
        }
    }
}


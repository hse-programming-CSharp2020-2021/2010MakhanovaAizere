using System;

namespace _2
{
    class Program
    {
        static void M(int a)
        {
            int n = a;
            Console.Write(n % 10);
            while ((n /= 10) != 0)
                Console.Write(n % 10);
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    int a = int.Parse(Console.ReadLine());
                    M(a);
                    Console.WriteLine("Чтобы завершить нажмите ESC");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

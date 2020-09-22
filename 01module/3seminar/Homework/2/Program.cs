using System;

namespace _2
{
    class Program
    {
        /*Написать метод, преобразующий число переданное в качестве параметра в число,
         * записанное теми же цифрами, но идущими в обратном порядке. 
         */

        static void M(int a)//создаем метод М
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
                    Console.WriteLine("Введите число");//вводим число
                    int a = int.Parse(Console.ReadLine());
                    M(a);//выводим через метод результат
                    Console.WriteLine("Чтобы завершить нажмите ESC");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch (Exception ex)//исключение
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

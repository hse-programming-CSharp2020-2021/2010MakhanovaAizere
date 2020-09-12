using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04_c_
{
    class Program
    {
        //Получить от пользователя четырехзначное натуральное число и напечатать его цифры в обратном порядке
        static void M(int n)//создаем метод М
        {
            int a, b, c, d;//объявляем переменные
            a = n / 1000;//выделяем 1 число
            b = n / 100 % 10;//выделяем 2 число
            c = n / 10 % 10;//выделяем 3 число
            d = n % 10;//выделяем 4 число
            Console.WriteLine($"Получившееся число={d}{c}{b}{a}");//выводим получившееся число

        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Введите четырехзначное натуральное число");
                    int n = int.Parse(Console.ReadLine());//вводим число
                    if (n > 999 && n < 9999)//исключение
                    {
                        M(n);//вызываем метод М для выполнения условия
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!");
                    }
                    
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07_c_
{
    class Program
    {
        /*Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа.
         * Второй метод возвращает квадрат и корень из числа.В основной программе пользователь вводит дробное число.  
         * Программа должна вычислить, если это возможно, значение корня, квадрата числа,выделить целую и дробную 
         * часть из числа.
         */
        static void M1(double a)//первый метод
        {
            double x, y;//создаем дополнительные переменные
            Console.WriteLine("Целая часть числа:");
            x = Math.Round(a);//вычисляем целую часть числа
            Console.WriteLine(x);
            Console.WriteLine("Дробная часть числа:");
            y = a - x;//вычисляем дробную часть числа
            Console.WriteLine(y);
        }
        static void M2(double a)//второй метод
        {
            double x;//создаем дополнительные переменные
            double y;
            Console.WriteLine("Квадрат числа:");
            x = a * a;//возводим в квадрат
            Console.WriteLine(x);
            Console.WriteLine("Корень числа :");
            if (a >= 0)//рассматриваем два случая для извлечения корня
            {
                y = Math.Sqrt(a);
                Console.WriteLine(y);
                Console.WriteLine(-y);
            }
            else
            {
                Console.WriteLine("Не существует");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Введите число");
                    double a = double.Parse(Console.ReadLine());//вводим число
                    M1(a);//вызываем метод М1
                    M2(a);//вызываем метод М2
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

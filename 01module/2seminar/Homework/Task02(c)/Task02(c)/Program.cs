using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_c_
{
    class Program
    {
        /*Ввести натуральное трехзначное число Р. Найти наибольшее целое число, 
         * которое можно получить, переставляя цифры числа Р*/
        static void M(int n)
        {
            int x, y, z;
            if (n < 100 || n > 999)//исключения
            {
                Console.WriteLine("Ошибка!");
            }
            else
            {
                x = n / 100; //1 цифра
                y = n % 100 / 10;//2 цифра
                z = n % 10;//3 цифра
                //найдем максимальное, среднее и минимальное значения
                int minXY = Math.Min(x, y);//можно найти через if
                int maxXY = Math.Max(x, y);
                int mx = maxXY < z ? z : maxXY;
                int mn = minXY > z ? z : minXY;
                int md = maxXY == mx && minXY == mn ? z : x == mn || x == mx ? y : x;

                Console.WriteLine($"Максимальное число={mx}{md}{mn}") ;//вывод результата

            }
           
           
        }
        static void Main(string[] args)
        {
            try
            {
                do//do{}while() можно заменить на просто while()
                {
                    Console.WriteLine("Введите трехзначное натуральное число");
                    int n = int.Parse(Console.ReadLine());//вводим трехзначное натуральное число
                    M(n);//вызываем метод
                   
                    Console.WriteLine("Чтобы завершить нажмите ESC");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch (Exception ex) //обработка исключений
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

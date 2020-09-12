using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_c_
{
    class Program
    {
        //Получить от пользователя три вещественных числа и проверить для них неравенство треугольника
        static void M (double a, double b, double c)//создаем метод М
        {
            //объявляем три вещественных числа
            double x = Math.Abs(a);
            double y = Math.Abs(b);
            double z = Math.Abs(c);
            //находим максимальную сторону
            double minXY = Math.Min(x, y);
            double maxXY = Math.Max(x, y);
            double max = maxXY < z ? z : maxXY;
            double min = minXY > z ? z : minXY;
            double mid = maxXY == max && minXY == min ? z : x == min || x == max ? y : x;
            Console.WriteLine(max <= mid + min ? "Выполняется" : "Не выполняется");//проверяем на неравенство треугольника
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Выполняется ли неравенство треугольника?");
                    Console.WriteLine("Введите длины сторон треугольника(три вещественных числа)");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    M(a, b, c);
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

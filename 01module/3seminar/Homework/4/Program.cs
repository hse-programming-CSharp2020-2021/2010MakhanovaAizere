using System;

namespace _4
{
    class Program
    {
        /*Написать метод, вычисляющий значение функции G=F(X,Y)
             *   {  𝑋+sin⁡(𝑌),𝑋<𝑌 и 𝑋>0
             * G={  𝑌−cos⁡(𝑋),𝑋>𝑌 и 𝑋<0
             *   {0.5∙𝑋∙𝑌, в остальных случаях
             */
        static void M(double x, double y)//создаем метод
        {
            double g;
            //исследуем каждый случай
            if (x < y && x > 0)
            {
                g = x + Math.Sin(y);
                Console.WriteLine($"G={g}");
            }
            if (x > y && x < 0)
            {
                g = y - Math.Cos(x);
                Console.WriteLine($"G={g}");
            }
            else
            {
                g = 0.5 * x * y;
                Console.WriteLine($"G={g}");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Введите два числа");
                    double a = double.Parse(Console.ReadLine());//вводим две переменные
                    double b = double.Parse(Console.ReadLine());
                    M(a, b);//вызываем метод
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

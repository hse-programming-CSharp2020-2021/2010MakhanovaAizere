using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CW1
{
    class Program
    {
        // добавим метод который выводит значение полинома
        static double Method(double x)
        {
            // минимальное кол-во операций умножения - 4
            double r = (x * (x * (x * (12 * x + 9) - 3) + 2) - 4);
            return r;
        }
        static void Main(string[] args)
        {
            try
            {
                double a;
                string str, rep;

                Console.WriteLine("Самостоятельная работа 1");
                Console.WriteLine("Требования: Ввести значение x и вывести значение полинома");
                // можно использовать if{}...else{}
                do
                {
                    do
                    {
                        Console.WriteLine("Введите значение x: ");
                        str = Console.ReadLine();
                    } while (!double.TryParse(str, out a));

                    // выводим а, вызываем метод
                    Console.WriteLine($"Ответ: {Method(a)}");

                    Console.WriteLine("Нажмите (Y) для повтора программы ");
                    rep = Console.ReadLine();
                }
                while ((rep == "y") || (rep == "Y"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
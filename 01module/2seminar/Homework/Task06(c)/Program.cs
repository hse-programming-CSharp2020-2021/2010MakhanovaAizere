using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_c_
{
    class Program
    {
        /*Получить от пользователя вещественно значение - бюджет пользователя
         * и целое число - процент бюджета, веделенный на компьютерные игры. 
         * Вычислить и вывести на экран сумму в долларах, выделенную на компьютерные игры.
         */
        static void M(double a, int b)//а-бюджет, b-процент 
        {
            double c;//объявляем переменную для нахождения суммы
            c = a * b / 100;//расчитываем сумму
            double d = c / 74.92;//переводим в доллары
            Console.WriteLine("Сумма равна:");
            Console.WriteLine(string.Format(new System.Globalization.CultureInfo("en-US"), "{0:c}", d));//используем спецификатор формата для валюты
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Бюджет:");
                    double a = double.Parse(Console.ReadLine());//вводим значение бюджета
                    Console.WriteLine("Процент от бюджета:");
                    int b = int.Parse(Console.ReadLine());//вводим значение процента от бюджета
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

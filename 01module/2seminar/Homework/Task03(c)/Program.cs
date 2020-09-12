using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03_c_
{
    class Program
    {
        //Введя значения коэф. А, В, С, вычислить корни квадратного уравнения.
        static void M(int a, int b, int c)//создаем метод М
        {
            double d, x1, x2;//объявляем переменные
            d = (b * b - 4 * a * c);//вычисляем дискриминант
            x1 = (-b + Math.Sqrt(d)) / 2;//вычисляем корень 1
            x2 = (-b - Math.Sqrt(d)) / 2;//вычисляем корень 2
            Console.WriteLine(d>0?$"Корни уравнения:{ x1}, { x2}":"Выявлено наличие комплексных корней");
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    //вводим коэффициенты
                    Console.WriteLine("Введите коэффициенты");
                    Console.WriteLine("а=");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("b=");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("c=");
                    int c = int.Parse(Console.ReadLine());
                    M(a, b, c);//вызываем метод
                    
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

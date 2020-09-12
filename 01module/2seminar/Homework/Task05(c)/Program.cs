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
        static void M (double a, double b, double c)
        {
            double x = Math.Abs(a);
            double y = Math.Abs(b);
            double z = Math.Abs(c);
            Console.WriteLine(x <= y + z ? "Выполняется" : "Не выполняется");
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
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

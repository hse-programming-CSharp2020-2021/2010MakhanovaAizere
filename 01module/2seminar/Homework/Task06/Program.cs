using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задан кркруг с центом в начале координат и радиусом R=10.
             * Ввести координаты точки и вывести сообщение: "Точка внутри круга!" или "Точка вне круга!".
             */
            try
            {
                do
                {
                    double x, y;
                    Console.WriteLine("Введите x");
                    Console.Write("x=");
                    double.TryParse(Console.ReadLine(), out x);
                    Console.WriteLine("Введите y");
                    Console.Write("y=");
                    double.TryParse(Console.ReadLine(), out y);
                    string report = "Точка";
                    report += x * x + y * y > 100 ? "Вне круга" : "Внутри круга";
                    Console.WriteLine(report);  
                    Console.WriteLine("Чтобы завершить нажмите ESC");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;

namespace _5
{
    class Program
    {
        /*Написать метод, вычисляющий значение функции G=F(X)
        𝐺={(sin⁡(𝜋/2),𝑋≤0.5
          {sin⁡((𝜋∙(𝑥−1))/2),𝑋>0.5*/
        static void M(double x)//создаем метод для вычисления функции
        {
            double g;
            if (x <= 0.5)
            {
                g = Math.Sin((Math.PI) / 2);
                Console.WriteLine($"G={g}");
            }
            if (x > 0.5)
            {
                g = Math.Sin((Math.PI * (x - 1)) / 2);
                Console.WriteLine($"G={g}");
            }
            
        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Введите число");//вводим значение х
                    double x = double.Parse(Console.ReadLine());
                    M(x);//вызываем метод
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

using System;

namespace _6
{
    /*Трехзначным целым числом кодируется номер аудитории в учебном корпусе.
     * Старшая цифра обозначают номер этажа, а две младшие –  номер аудитории на этаже. 
     * Из трех аудиторий определить и вывести на экран ту аудиторию, которая имеет минимальный номер внутри этажа.
     * Если таких аудиторий несколько - вывести любую из них. 
     */
    class Program
    {
        static void M(ref int x, ref int y, ref int z)
        {
            int m = Math.Min(x, y);
            int min = m > z ? z : m;

            int f = min / 100;
            int au = min % 100;


            Console.WriteLine($" Минимальный номер внутри этажа: {f} этаж {au} аудитория ");
        }
        static void Main(string[] args)
        {
            // Задаём переменные для ввода
            int a, b, c;
            do
            {
                Console.Clear();

                Console.WriteLine("Введите номер этажа и номер аудитории на этаже");
                Console.WriteLine("Например: 322 (3-этаж 22 аудитория)");
                Console.Write("Введите первый номер этажа и аудитории: ");
                while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a >= 999)
                {
                    Console.WriteLine("Incorrect input");
                    Console.Write("Введите первый номер этажа и аудитории: ");
                }
                Console.Write("Введите второй номер этажа и аудитории : ");
                while (!int.TryParse(Console.ReadLine(), out b) || b < 0 || b >= 999)
                {
                    Console.WriteLine("Incorrect input");
                    Console.Write("Введите второй номер этажа и аудитории : ");
                }
                Console.Write("Введите третий номер этажа и аудитории: ");
                while (!int.TryParse(Console.ReadLine(), out c) || c < 0 || c >= 999)
                {
                    Console.WriteLine("Incorrect input");
                    Console.Write("Введите третий номер этажа и аудитории: ");
                }

                // Вызов метода
                M(ref a, ref b, ref c);

                Console.WriteLine("Для выхода нажмите ESC...");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
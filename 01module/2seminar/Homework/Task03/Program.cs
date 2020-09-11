using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        /*написать метод, так обменивающий значения трех переменных x, y, z,
         * чтобы выпелнилось требование: x<=y<=z.
        В основной программе, вводить значения трех переменных и упорядочить 
        их с помощью обращения у написанному методу.
        Для выхода из программы вводите ESC, для повторения решения-любую другую клавишу.*/
         static void Method( int x,  int y,  int z)/* создаем метод и вводим дополнительные 
                                                        переменные для выполнения условия*/
        {
            int a , b, c;//Добавляем вспомогательные переменные
            a = x < y ? (z < x ? z : x) : (z < y ? z : y);
            b = x < y ? (y < z ? y : z) : (z < x ? z : x);
            c = x > y ? (z > x ? z : x) : (z > y ? z : y);
            

            x = a;
            y = b;
            z = c;

            Console.WriteLine(a);//выводим результат
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    int x, y, z;
                    Console.WriteLine("Введите значение х");
                    x = int.Parse(Console.ReadLine()); //вводим переменные
                    Console.WriteLine("Введите значение y");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите значение z");
                    z = int.Parse(Console.ReadLine());
                    Method(x, y, z);                   //вызываем метод Method
                    Console.WriteLine("Чтобы завершить нажмите ESC");
                    
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch(Exception ex) //обработка исключений
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Выделение отдельных  цифр  натурального числа. Вывести трехзначное натуральное число  и напечатать цифры "столбиком".
            try
            {
                do
                {



                    int a;//Вводим переменные
                    int b;
                    int c;
                    Console.WriteLine("Введите трехзначное натуральное число");
                    int n = int.Parse(Console.ReadLine());//Вводим трехзначное натуральное число
                                                          //Выделяем цифры:
                    a = n / 100; //1 цифра
                    b = n % 100 / 10;//2 цифра
                    c = n % 10;//3 цифра
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    Console.WriteLine("Чтобы завершить нажмите ESC");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }catch(Exception ex) //обработка исключений
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

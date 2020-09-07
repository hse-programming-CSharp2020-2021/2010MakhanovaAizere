using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double U, R;
            Console.WriteLine("Введите значение напряжения U");
            string a = Console.ReadLine();
            U = int.Parse(a);
            Console.WriteLine("Введите значение сопротивления R");
            string b = Console.ReadLine();
            R = int.Parse(b);
            Console.WriteLine("Cила тока I=" + (U / R).ToString("F4"));
            Console.WriteLine("Мощность Р=" + (Math.Pow(U, 2) / R).ToString("F4"));

        }
    }
}

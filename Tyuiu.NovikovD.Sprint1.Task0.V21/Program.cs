using System;
using Tyuiu.NovikovD.Sprint3.Task0.V24.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task0.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("* Спринт #3                                                 *");
            Console.WriteLine("* Task 0. Вариант 24                                        *");
            Console.WriteLine("* Выполнил: Новиков Д. | АСОиУБ-23-1                        *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                  *");
            Console.WriteLine("* Вычислить произведение ряда по формуле, при x = 5         *");
            Console.WriteLine("************************************************************");

            DataService ds = new DataService();
            int x = 5;
            double result = ds.CalculateProductSeries(x);

            Console.WriteLine($"Результат вычисления произведения: {result}");
            Console.WriteLine("************************************************************");

            Console.ReadKey();
        }
    }
}

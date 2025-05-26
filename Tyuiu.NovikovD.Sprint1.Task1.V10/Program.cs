using System;
using Tyuiu.NovikovD.Sprint3.Task1.V7.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double a = 0.25;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклы. Оператор while                                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет произведение ряда:               *");
            Console.WriteLine("* p = произведение ((a^k + 1) * sin(5)), k от 1 до 9, a = 0.25           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"a = {a}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.CalculateSeriesProduct(a);
            Console.WriteLine($"Результат произведения ряда: {result:F6}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}

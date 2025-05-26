using System;
using Tyuiu.NovikovD.Sprint3.Task2.V14.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double x = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклы. Оператор do...while                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет произведение ряда:               *");
            Console.WriteLine("* p = Π ((x / k)^3), где k = 1..6, при x = 5                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.CalculateProduct(x);
            Console.WriteLine($"Результат произведения ряда: {result:F6}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}

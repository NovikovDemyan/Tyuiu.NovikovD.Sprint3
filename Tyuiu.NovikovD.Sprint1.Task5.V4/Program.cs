using System;
using Tyuiu.NovikovD.Sprint3.Task5.V29.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task5.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение функции y при X=2        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 2;
            Console.WriteLine($"X = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.CalculateFunction(x);
            Console.WriteLine($"Значение функции y при X=2: {result}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}

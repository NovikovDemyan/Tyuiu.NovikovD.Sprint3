using System;
using Tyuiu.NovikovD.Sprint2.Task0.V11.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task0.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений, которая вернет                *");
            Console.WriteLine("* логическую последовательность (True, False, True, False, True, False)   *");
            Console.WriteLine("* при x = 8105, y = 275                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 8105;
            int y = 275;
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] results = ds.GetCompareOperations(x, y);
            Console.WriteLine("Полученная последовательность:");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"Операция {i + 1}: {results[i]}");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
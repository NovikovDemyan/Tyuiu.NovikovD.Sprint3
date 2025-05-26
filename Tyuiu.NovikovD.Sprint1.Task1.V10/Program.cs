using System;
using Tyuiu.NovikovD.Sprint2.Task1.V5.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
            Console.WriteLine("* которая вернет последовательность (True, False, False, False, True, False)");
            Console.WriteLine("* при a = 154, b = 163, c = 134, d = 137                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 154;
            int b = 163;
            int c = 134;
            int d = 137;
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            Console.WriteLine($"D = {d}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] results = ds.GetLogicOperations(a, b, c, d);
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
using System;
using Tyuiu.NovikovD.Sprint2.Task2.V9.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task2.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры*");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной    *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine($"Точка с координатами ({x}, {y}) находится в заштрихованной области: {result}");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}

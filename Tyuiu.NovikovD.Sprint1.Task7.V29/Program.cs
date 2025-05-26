using System;
using Tyuiu.NovikovD.Sprint3.Task7.V15.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = sin(x) + (2x/3) - cos(x) * 4x на заданном диапазоне [-5, 5]     *");
            Console.WriteLine("* с шагом 1.                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double start = -5;
            double end = 5;
            double step = 1;
            Console.WriteLine($"Диапазон: [{start}, {end}] с шагом {step}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var result = ds.TabulateFunction(start, end, step);
            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("X\tF(X)");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}

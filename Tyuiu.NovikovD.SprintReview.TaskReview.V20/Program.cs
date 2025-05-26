using System;
using Tyuiu.NovikovD.Sprint3.SprintReview.V13.Lib;

namespace Tyuiu.NovikovD.Sprint3.SprintReview.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #SprintReview                                                   *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = 3x + 2 - (2x - x) / (cos(x) + 1) на заданном диапазоне [-5, 5]   *");
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

using System;
using Tyuiu.NovikovD.SprintReview.TaskReview.V20.Lib;

namespace Tyuiu.NovikovD.SprintReview.TaskReview.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #Review                                                          *");
            Console.WriteLine("* Тема: Итоговый обзор спринта                                            *");
            Console.WriteLine("* Задание #Review                                                         *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сложное математическое выражение  *");
            Console.WriteLine("* по формуле варианта 20 с округлением до 3 знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.CalculateReviewFormula(x, y);
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
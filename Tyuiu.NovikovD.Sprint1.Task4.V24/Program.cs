using System;
using Tyuiu.NovikovD.Sprint3.Task4.V8.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл while                                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке [-5;5] вычислить значение функции y=(x/sin(x))+0.5          *");
            Console.WriteLine("* При x=0 прервать цикл. Полученные значения перемножить.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;
            Console.WriteLine($"Начальное значение x = {start}");
            Console.WriteLine($"Конечное значение x = {stop}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.Calculate(start, stop);
            Console.WriteLine($"Произведение значений функции = {res}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
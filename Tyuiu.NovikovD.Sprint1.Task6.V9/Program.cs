using System;
using Tyuiu.NovikovD.Sprint3.Task6.V24.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task6.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Новиков Д.   | АСОиУБ-23-2                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая ищет среди целых чисел, принадлежащих      *");
            Console.WriteLine("* числовому отрезку [17, 26], количество всех делителей.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = 17;
            int end = 26;
            Console.WriteLine($"Числовой отрезок: [{start}, {end}]");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var result = ds.CountDivisorsInRange(start, end);
            foreach (var item in result)
            {
                Console.WriteLine($"Число {item.Key} имеет {item.Value} делителей.");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}

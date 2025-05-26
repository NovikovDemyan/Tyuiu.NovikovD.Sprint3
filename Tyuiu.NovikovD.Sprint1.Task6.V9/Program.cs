using System;
using Tyuiu.NovikovD.Sprint2.Task6.V3.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task6.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();

            Console.WriteLine("*************************************************************");
            Console.WriteLine("* Спринт #2                                                 *");
            Console.WriteLine("* Тема: Условные операторы if-else                          *");
            Console.WriteLine("* Задание #6                                                *");
            Console.WriteLine("* Вариант #3                                                *");
            Console.WriteLine("* Выполнил: Новиков Д. | АСОиУБ-23-1                        *");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                  *");
            Console.WriteLine("* По номеру дня недели (1-7) вывести название дня           *");
            Console.WriteLine("*************************************************************");

            Console.Write("Введите номер дня недели (1–7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindDayName(dayNumber);

            Console.WriteLine("************************************************************");
            Console.WriteLine($"Название дня недели: {result}");
            Console.WriteLine("************************************************************");

            Console.ReadKey();
        }
    }
}

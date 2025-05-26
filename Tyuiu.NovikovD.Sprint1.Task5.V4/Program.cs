using System;
using Tyuiu.NovikovD.Sprint2.Task5.V5.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("************************************************************");
            Console.WriteLine("* Спринт #2                                                 *");
            Console.WriteLine("* Тема: Оператор switch                                     *");
            Console.WriteLine("* Задание #5                                               *");
            Console.WriteLine("* Вариант #5                                               *");
            Console.WriteLine("* Выполнил: Новиков Д. | АСОиУБ-23-2                       *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                  *");
            Console.WriteLine("* По заданному номеру карты (6 <= k <= 14) определить её   *");
            Console.WriteLine("* достоинство.                                             *");
            Console.WriteLine("************************************************************");

            Console.Write("Введите номер карты (от 6 до 14): ");
            int k = Convert.ToInt32(Console.ReadLine());

            string result = ds.FindCardValue(k);

            Console.WriteLine("************************************************************");
            Console.WriteLine($"Достоинство карты: {result}");
            Console.WriteLine("************************************************************");

            Console.ReadKey();
        }
    }
}

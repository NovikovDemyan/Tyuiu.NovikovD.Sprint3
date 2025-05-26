using System;
using Tyuiu.NovikovD.Sprint2.Task3.V11.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("************************************************************");
            Console.WriteLine("* Спринт #2                                                *");
            Console.WriteLine("* Тема: Условный оператор if-else                          *");
            Console.WriteLine("* Задание #3                                               *");
            Console.WriteLine("* Вариант #11                                              *");
            Console.WriteLine("* Выполнил: Новиков Д. | АСОиУБ-23-1                       *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 *");
            Console.WriteLine("* Вычислить значение функции Y при вводе значения X.       *");
            Console.WriteLine("* Использовать вложенные операторы if-else.                *");
            Console.WriteLine("* Округлить результат до 3 знаков после запятой.           *");
            Console.WriteLine("************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = ds.Calculate(x);

            Console.WriteLine("************************************************************");
            Console.WriteLine($"Результат: Y = {y}");
            Console.WriteLine("************************************************************");
            Console.ReadKey();
        }
    }
}

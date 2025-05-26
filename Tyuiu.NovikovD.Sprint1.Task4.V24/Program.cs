using System;
using Tyuiu.NovikovD.Sprint2.Task4.V14.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("************************************************************");
            Console.WriteLine("* Спринт #2                                                 *");
            Console.WriteLine("* Тема: Тернарный оператор                                 *");
            Console.WriteLine("* Задание #4                                               *");
            Console.WriteLine("* Вариант #14                                              *");
            Console.WriteLine("* Выполнил: Новиков Д. | АСОиУБ-23-1                       *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                 *");
            Console.WriteLine("* Вычислить значение Z по формуле с тернарным оператором. *");
            Console.WriteLine("************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);

            Console.WriteLine("************************************************************");
            Console.WriteLine($"Результат: Z = {result}");
            Console.WriteLine("************************************************************");

            Console.ReadKey();
        }
    }
}

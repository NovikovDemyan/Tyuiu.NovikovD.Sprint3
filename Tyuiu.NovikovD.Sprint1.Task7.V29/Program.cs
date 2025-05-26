using System;
using Tyuiu.NovikovD.Sprint2.Task7.V8.Lib;

namespace Tyuiu.NovikovD.Sprint2.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("************************************************************");
            Console.WriteLine("* Спринт #2                                                 *");
            Console.WriteLine("* Задание #7                                                *");
            Console.WriteLine("* Вариант #8                                                *");
            Console.WriteLine("* Выполнил: Новиков Д. | АСОиУБ-23-1                        *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                  *");
            Console.WriteLine("* Принадлежит ли точка (X, Y) заштрихованной области?      *");
            Console.WriteLine("************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("************************************************************");
            if (result)
                Console.WriteLine("Точка принадлежит заштрихованной области.");
            else
                Console.WriteLine("Точка НЕ принадлежит заштрихованной области.");
            Console.WriteLine("************************************************************");

            Console.ReadKey();
        }
    }
}

using System;
using Tyuiu.NovikovD.Sprint2.SprintReview.V3.Lib;

namespace Tyuiu.NovikovD.Sprint2.SprintReview.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("************************************************************");
            Console.WriteLine("* Спринт #2                                                 *");
            Console.WriteLine("* Sprint Review                                             *");
            Console.WriteLine("* Вариант #3                                                *");
            Console.WriteLine("* Выполнил: Новиков Д. | АСОиУБ-23-1                        *");
            Console.WriteLine("************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                  *");
            Console.WriteLine("* Определить, принадлежит ли точка (x, y) заштрихованной    *");
            Console.WriteLine("* области, ограниченной дугой окружности и параболой.       *");
            Console.WriteLine("************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool result = ds.IsPointInShadedArea(x, y);

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

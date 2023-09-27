using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoginMA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GoginMA.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Гогин М. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                             *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Гогин Михаил Александрович | АСОиУБ-23-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).  *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                      *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            
            Console.WriteLine("Введите координату X первой точки:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой точки:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату X второй точки:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй точки:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

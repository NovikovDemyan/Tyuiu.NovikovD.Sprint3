using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoginMA.Sprint1.Task6.V6.Lib;

namespace Tyuiu.GoginMA.Sprint1.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Гогин М. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Работа со строками класс String                                  *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Гогин Михаил Александрович | АСОиУБ-23-1                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                         *");
            Console.WriteLine("* Напечатать все слова, удалив из них первую букву.                      *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите строку:");
            string value = Console.ReadLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(ds.DeleteFirstLetter(value));
            Console.ReadKey();
        }
    }
}

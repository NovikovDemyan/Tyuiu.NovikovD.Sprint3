using System;
using Tyuiu.NovikovD.Sprint3.Task3.V7.Lib;

namespace Tyuiu.NovikovD.Sprint3.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string input = "gft hggt ntg";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклы. Foreach                                                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Новиков Д. | АСОиУБ-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach, заменить буквы g на цифру 4 в строке:          *");
            Console.WriteLine("* gft hggt ntg                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string output = ds.ReplaceGWith4(input);
            Console.WriteLine(output);

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}

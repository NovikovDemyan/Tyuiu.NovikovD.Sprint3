using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NovikovD.Sprint3.Task4.V8.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1;
            int x = startValue;

            while (x <= stopValue)
            {
                if (x == 0)
                {
                    break; // Прерывание цикла при x = 0
                }

                double denominator = Math.Sin(x);
                if (Math.Abs(denominator) < 0.0001) // Проверка на ноль
                {
                    x++;
                    continue;
                }

                double y = (x / denominator) + 0.5;
                product *= y;
                x++;
            }

            return Math.Round(product, 3);
        }
    }
}
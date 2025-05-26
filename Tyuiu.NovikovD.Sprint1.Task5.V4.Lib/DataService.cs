using System;

namespace Tyuiu.NovikovD.Sprint3.Task5.V29.Lib
{
    public class DataService
    {
        public double CalculateFunction(double x)
        {
            double sum = 0;

            // Внешний цикл по i от 1 до 3
            for (int i = 1; i <= 3; i++)
            {
                // Внутренний цикл по k от 1 до 10
                for (int k = 1; k <= 10; k++)
                {
                    sum += x / k;
                }
            }

            // Добавление значения синуса
            sum += Math.Sin(x);

            return sum;
        }
    }
}

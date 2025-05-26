using System;

namespace Tyuiu.NovikovD.Sprint3.Task0.V24.Lib
{
    public class DataService
    {
        public double CalculateProductSeries(int x)
        {
            double result = 1.0;
            for (int i = 1; i <= 7; i++)
            {
                double term = Math.Pow(3.0 / (i + x - (i * i)), 2);
                result *= term;
            }
            return Math.Round(result, 3);
        }
    }
}

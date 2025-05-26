using System;

namespace Tyuiu.NovikovD.Sprint3.Task1.V7.Lib
{
    public class DataService
    {
        public double CalculateSeriesProduct(double a)
        {
            int k = 1;
            double result = 1;
            while (k <= 9)
            {
                double term = Math.Pow(a, k) + 1;
                result *= term * Math.Sin(5);
                k++;
            }
            return result;
        }
    }
}

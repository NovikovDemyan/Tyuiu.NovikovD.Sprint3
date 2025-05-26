using System;

namespace Tyuiu.NovikovD.Sprint3.Task2.V14.Lib
{
    public class DataService
    {
        public double CalculateProduct(double x)
        {
            int k = 1;
            double result = 1;

            do
            {
                double term = Math.Pow((x / k), 3);
                result *= term;
                k++;
            } while (k <= 6);

            return result;
        }
    }
}

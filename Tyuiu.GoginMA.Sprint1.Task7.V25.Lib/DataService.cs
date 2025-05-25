using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovikovD.Sprint1.Task7.V29.Lib
{
    public class DataService : ISprint1Task7V29
    {
        public double Calculate(double x, double y)
        {
            double denominator1 = x * y - 3;
            double denominator2 = x * y + 5;

            if (Math.Abs(denominator1) < 0.0001 || Math.Abs(denominator2) < 0.0001)
                throw new ArgumentException("Знаменатель не может быть равен нулю");

            double term1 = Math.Pow(Math.Cos(x), 3) / denominator1;
            double term2 = Math.Pow(Math.Sin(x), 5) / denominator2;

            double result = x - term1 + term2;
            return Math.Round(result, 3);
        }
    }
}

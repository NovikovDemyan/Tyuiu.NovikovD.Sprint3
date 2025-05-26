using System;
using System.Collections.Generic;

namespace Tyuiu.NovikovD.Sprint3.SprintReview.V13.Lib
{
    public class DataService
    {
        public Dictionary<double, double> TabulateFunction(double start, double end, double step)
        {
            Dictionary<double, double> functionValues = new Dictionary<double, double>();

            for (double x = start; x <= end; x += step)
            {
                try
                {
                    double denominator = Math.Cos(x) + 1;
                    if (denominator == 0)
                    {
                        functionValues[x] = 0; // При делении на ноль вернуть значение 0
                    }
                    else
                    {
                        double y = 3 * x + 2 - (2 * x - x) / denominator;
                        y = Math.Round(y, 2); // Округление до двух знаков после запятой
                        functionValues[x] = y;
                    }
                }
                catch (Exception)
                {
                    functionValues[x] = 0; // При исключении вернуть значение 0
                }
            }

            return functionValues;
        }
    }
}

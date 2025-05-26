using System;
using System.Collections.Generic;

namespace Tyuiu.NovikovD.Sprint3.Task7.V15.Lib
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
                    double y = Math.Sin(x) + (2 * x) / 3 - Math.Cos(x) * 4 * x;
                    y = Math.Round(y, 2); // Округление до двух знаков после запятой
                    functionValues[x] = y;
                }
                catch (DivideByZeroException)
                {
                    functionValues[x] = 0; // При делении на ноль вернуть значение 0
                }
            }

            return functionValues;
        }
    }
}

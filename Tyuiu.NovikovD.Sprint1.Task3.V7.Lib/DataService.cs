using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NovikovD.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 0)
            {
                y = (x + (x - 15)) / (x - 19);
                y = Math.Pow(y, x);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
            }
            else if (x > -15 && x < 0)
            {
                y = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
            }
            else if (x > -20 && x <= -15)
            {
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), 1.0 / x);
            }
            else // x <= -20
            {
                y = x + 10 * (1.0 / x);
            }

            return Math.Round(y, 3);
        }
    }
}

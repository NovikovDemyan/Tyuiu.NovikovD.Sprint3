using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoginMA.Sprint1.Task7.V25.Lib
{
    public class DataService : ISprint1Task7V25
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow(Math.E, x) - ((Math.Pow(y, 2) + 6 + Math.Cos(Math.Pow(x, 3)) + (x * y) - (2 * Math.Pow(x, 2))) / (Math.Sin(Math.Pow(x, 4) + 13) + (9 * y) - 2));
            return Math.Round(res, 3);
        }
    }
}

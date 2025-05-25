using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NovikovD.Sprint1.Task4.V24.Lib
{
    public class DataService : ISprint1Task4V24
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Log(x * y);
            double denominator = x + Math.Sqrt(2 * Math.Pow(y, 2));
            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GoginMA.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            var res = ((Math.Cos((Math.PI / x))) / (3 * Math.Pow(Math.E, (x + y))));
            return Math.Round(res, 3);
        }
    }
}

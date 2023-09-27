using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoginMA.Sprint1.Task5.V1.Lib
{
    public class DataService
    {
        public double DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            return (Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
        }
    }
}

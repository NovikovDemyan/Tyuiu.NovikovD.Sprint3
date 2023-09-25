using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoginMA.Sprint1.Task3.V3.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GoginMA.Sprint1.Task3.V3.Lib
{
    public class DataService : ISprint1Task3V3
    {
        public double ParallelepipedVolume(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
